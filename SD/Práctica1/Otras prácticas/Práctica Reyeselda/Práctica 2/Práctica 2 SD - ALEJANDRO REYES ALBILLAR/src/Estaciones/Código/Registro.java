/*
 * Copyright 2001-2010 The Apache Software Foundation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
import java.net.InetAddress;
import java.net.UnknownHostException;

import org.apache.juddi.api_v3.AccessPointType;
import org.apache.juddi.v3.client.config.UDDIClient;
import org.apache.juddi.v3.client.transport.Transport;
import org.uddi.api_v3.AccessPoint;
import org.uddi.api_v3.AuthToken;
import org.uddi.api_v3.BindingTemplate;
import org.uddi.api_v3.BindingTemplates;
import org.uddi.api_v3.BusinessDetail;
import org.uddi.api_v3.BusinessEntity;
import org.uddi.api_v3.BusinessService;
import org.uddi.api_v3.DiscardAuthToken;
import org.uddi.api_v3.GetAuthToken;
import org.uddi.api_v3.Name;
import org.uddi.api_v3.SaveBusiness;
import org.uddi.api_v3.SaveService;
import org.uddi.api_v3.ServiceDetail;
import org.uddi.v3_service.UDDIPublicationPortType;
import org.uddi.v3_service.UDDISecurityPortType;

/**
 * This shows you to interact with a UDDI server by publishing a Business,
 * Service and Binding Template. It uses some fairly generic code that should be
 * mostly portable to any other UDDI client library and is therefore consider
 * "portable". URLs are set in uddi.xml
 *
 */
public class SimplePublishPortable {

	private static UDDISecurityPortType security = null;
	private static UDDIPublicationPortType publish = null;

	public SimplePublishPortable() {
		try {
			// create a client and read the config in the archive;
			// you can use your config file name
			UDDIClient uddiClient = new UDDIClient("uddi.xml");
			// a UddiClient can be a client to multiple UDDI nodes, so
			// supply the nodeName (defined in your uddi.xml.
			// The transport can be WS, inVM, RMI etc which is defined in the uddi.xml
			Transport transport = uddiClient.getTransport("default");
			// Now you create a reference to the UDDI API
			security = transport.getUDDISecurityService();
			publish = transport.getUDDIPublishService();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public String IP() {
		InetAddress localHost;
		try {
			localHost = InetAddress.getLocalHost();
			System.out.println(localHost.getHostName());
			System.out.println(localHost.getHostAddress());
			return localHost.getHostAddress();
		} catch (UnknownHostException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		}
	}

	/**
	 * This function shows you how to publish to UDDI using a fairly generic
	 * mechanism that should be portable (meaning use any UDDI v3 library
	 * with this code)
	 */
	public void publish() {
		try {

			// Login aka retrieve its authentication token
			GetAuthToken getAuthTokenMyPub = new GetAuthToken();
			getAuthTokenMyPub.setUserID("juddi"); // your username
			getAuthTokenMyPub.setCred("juddi"); // your password
			AuthToken myPubAuthToken = security.getAuthToken(getAuthTokenMyPub);
			System.out.println(getAuthTokenMyPub.getUserID() + "'s AUTHTOKEN = " + "******* never log auth tokens!");

			// Creating the parent business entity that will contain our service.
			BusinessEntity myBusEntity = new BusinessEntity();
			Name myBusName = new Name();
			myBusName.setValue("Estaciones");
			myBusEntity.getName().add(myBusName);

			// Adding the business entity to the "save" structure, using our publisher's authentication info and saving away.
			SaveBusiness sb = new SaveBusiness();
			sb.getBusinessEntity().add(myBusEntity);
			sb.setAuthInfo(myPubAuthToken.getAuthInfo());
			BusinessDetail bd = publish.saveBusiness(sb);
			String myBusKey = bd.getBusinessEntity().get(0).getBusinessKey();
			System.out.println("Clave de Estaciones:  " + myBusKey);

			// Creating a service to save. Only adding the minimum data: the parent business key retrieved from saving the business
			// above and a single name.
			BusinessService myService = new BusinessService();
			myService.setBusinessKey(myBusKey);
			Name myServName = new Name();
			myServName.setValue("Estacion");
			myService.getName().add(myServName);

			// Add binding templates, etc...
			BindingTemplate myBindingTemplate = new BindingTemplate();
			AccessPoint accessPoint = new AccessPoint();
			accessPoint.setUseType(AccessPointType.WSDL_DEPLOYMENT.toString());
			accessPoint.setValue("http://" + IP() + ":8080/Station/services/Station.StationHttpSoap11Endpoint/");
			myBindingTemplate.setAccessPoint(accessPoint);
			BindingTemplates myBindingTemplates = new BindingTemplates();
			// optional but recommended step, this annotations our binding with all the standard SOAP tModel instance infos
			myBindingTemplate = UDDIClient.addSOAPtModels(myBindingTemplate);
			myBindingTemplates.getBindingTemplate().add(myBindingTemplate);

			myService.setBindingTemplates(myBindingTemplates);

			// Adding the service to the "save" structure, using our publisher's authentication info and saving away.
			SaveService ss = new SaveService();
			ss.getBusinessService().add(myService);
			ss.setAuthInfo(myPubAuthToken.getAuthInfo());
			ServiceDetail sd = publish.saveService(ss);
			String myServKey = sd.getBusinessService().get(0).getServiceKey();
			System.out.println("Clave de Estación:  " + myServKey);

			security.discardAuthToken(new DiscardAuthToken(myPubAuthToken.getAuthInfo()));
			// Now you have published a business and service via
			// the jUDDI API!
			System.out.println("Success!");

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static void main(String args[]) {
		System.out.println("Empieza");
		SimplePublishPortable sp = new SimplePublishPortable();
		sp.publish();
	}
}
