/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/9.0.10
 * Generated at: 2018-12-10 21:58:17 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp.js;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import org.apache.juddi.webconsole.resources.ResourceLoader;

public final class i18n_js_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final javax.servlet.jsp.JspFactory _jspxFactory =
          javax.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  private static final java.util.Set<java.lang.String> _jspx_imports_packages;

  private static final java.util.Set<java.lang.String> _jspx_imports_classes;

  static {
    _jspx_imports_packages = new java.util.HashSet<>();
    _jspx_imports_packages.add("javax.servlet");
    _jspx_imports_packages.add("javax.servlet.http");
    _jspx_imports_packages.add("javax.servlet.jsp");
    _jspx_imports_classes = new java.util.HashSet<>();
    _jspx_imports_classes.add("org.apache.juddi.webconsole.resources.ResourceLoader");
  }

  private volatile javax.el.ExpressionFactory _el_expressionfactory;
  private volatile org.apache.tomcat.InstanceManager _jsp_instancemanager;

  public java.util.Map<java.lang.String,java.lang.Long> getDependants() {
    return _jspx_dependants;
  }

  public java.util.Set<java.lang.String> getPackageImports() {
    return _jspx_imports_packages;
  }

  public java.util.Set<java.lang.String> getClassImports() {
    return _jspx_imports_classes;
  }

  public javax.el.ExpressionFactory _jsp_getExpressionFactory() {
    if (_el_expressionfactory == null) {
      synchronized (this) {
        if (_el_expressionfactory == null) {
          _el_expressionfactory = _jspxFactory.getJspApplicationContext(getServletConfig().getServletContext()).getExpressionFactory();
        }
      }
    }
    return _el_expressionfactory;
  }

  public org.apache.tomcat.InstanceManager _jsp_getInstanceManager() {
    if (_jsp_instancemanager == null) {
      synchronized (this) {
        if (_jsp_instancemanager == null) {
          _jsp_instancemanager = org.apache.jasper.runtime.InstanceManagerFactory.getInstanceManager(getServletConfig());
        }
      }
    }
    return _jsp_instancemanager;
  }

  public void _jspInit() {
  }

  public void _jspDestroy() {
  }

  public void _jspService(final javax.servlet.http.HttpServletRequest request, final javax.servlet.http.HttpServletResponse response)
      throws java.io.IOException, javax.servlet.ServletException {

    if (!javax.servlet.DispatcherType.ERROR.equals(request.getDispatcherType())) {
      final java.lang.String _jspx_method = request.getMethod();
      if ("OPTIONS".equals(_jspx_method)) {
        response.setHeader("Allow","GET, HEAD, POST, OPTIONS");
        return;
      }
      if (!"GET".equals(_jspx_method) && !"POST".equals(_jspx_method) && !"HEAD".equals(_jspx_method)) {
        response.setHeader("Allow","GET, HEAD, POST, OPTIONS");
        response.sendError(HttpServletResponse.SC_METHOD_NOT_ALLOWED, "JSPs only permit GET, POST or HEAD. Jasper also permits OPTIONS");
        return;
      }
    }

    final javax.servlet.jsp.PageContext pageContext;
    javax.servlet.http.HttpSession session = null;
    final javax.servlet.ServletContext application;
    final javax.servlet.ServletConfig config;
    javax.servlet.jsp.JspWriter out = null;
    final java.lang.Object page = this;
    javax.servlet.jsp.JspWriter _jspx_out = null;
    javax.servlet.jsp.PageContext _jspx_page_context = null;


    try {
      response.setContentType("application/javascript;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;

      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("\r\n");
      out.write("//<script type=\"text/javascript\">\r\n");
      out.write("    var i18n_clicktoedit=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.clicktoedit")));
      out.write("\";\r\n");
      out.write("    var i18n_loading=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.loading")));
      out.write("\";\r\n");
      out.write("    var i18n_login=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "navbar.login.button")));
      out.write("\";\r\n");
      out.write("    var il8n_picker=\"");
      out.print( org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.picker")));
      out.write("\";\r\n");
      out.write("    var i18n_name=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.name")));
      out.write("\";\r\n");
      out.write("    var i18n_value=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.value")));
      out.write("\";\r\n");
      out.write("    var i18n_key=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.key")));
      out.write("\";\r\n");
      out.write("    var i18n_lang=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.lang")));
      out.write("\";\r\n");
      out.write("    var i18n_email=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.email")));
      out.write("\";\r\n");
      out.write("    var i18n_type=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.type")));
      out.write("\";\r\n");
      out.write("    var i18n_ok=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "actions.ok")));
      out.write("\";\r\n");
      out.write("    var i18n_descriptionAdd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.description.add")));
      out.write("\";\r\n");
      out.write("    var i18n_description=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.description")));
      out.write("\";\r\n");
      out.write("    var i18n_contactPrimary=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.contact.primary")));
      out.write("\";\r\n");
      out.write("    var i18n_contactType=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.contact.type")));
      out.write("\";\r\n");
      out.write("    var i18n_contactTypeDefault=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.contact.default")));
      out.write("\";\r\n");
      out.write("    var i18n_address=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.address")));
      out.write("\";\r\n");
      out.write("    var i18n_addressValue=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.addressvalue")));
      out.write("\";\r\n");
      out.write("    var i18n_addressDefaultType=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.addresstype.default")));
      out.write("\";\r\n");
      out.write("    var i18n_addressLineAdd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.addressline.add")));
      out.write("\";\r\n");
      out.write("    \r\n");
      out.write("    var i18n_keyname_optional=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.keyname.optional")));
      out.write("\";\r\n");
      out.write("    var i18n_keyvalue_optional=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.keyvalue.optional")));
      out.write("\";\r\n");
      out.write("    \r\n");
      out.write("    var i18n_addrefcat=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.keyrefcat.add")));
      out.write("\"; \r\n");
      out.write("    \r\n");
      out.write("    var i18n_addressSortCode=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.sortcode")));
      out.write("\";\r\n");
      out.write("    var i18n_phone=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.phone")));
      out.write("\";\r\n");
      out.write("    \r\n");
      out.write("    var i18n_phoneType=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.phone.types")));
      out.write("\";\r\n");
      out.write("    \r\n");
      out.write("    \r\n");
      out.write("    var i18n_bindingTemplateKey=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.bindingtemplate.key")));
      out.write("\";\r\n");
      out.write("    var i18n_bindingTemplateDescriptionAdd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.bindingtemplate.description.add")));
      out.write("\";\r\n");
      out.write("    var i18n_accesspoint=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.accesspoint")));
      out.write("\";\r\n");
      out.write("    var i18n_accesspointType=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.accesspoint.type")));
      out.write("\";\r\n");
      out.write("    var i18n_accesspointValue=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.accesspoint.value")));
      out.write("\";\r\n");
      out.write("    \r\n");
      out.write("    var i18n_tmodelinstanceinfo=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.info")));
      out.write("\";\r\n");
      out.write("    var i18n_tmodelinstanceinfoDescription=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.info.desc")));
      out.write("\";\r\n");
      out.write("    var i18n_tmodelinstanceinfoAdd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.add")));
      out.write("\";\r\n");
      out.write("    var i18n_bindingTemplateKeyRefCat=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.bindingtemplate.keyrefcat")));
      out.write("\";\r\n");
      out.write("    var i18n_bindingTemplateKeyRefCatGrp=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.bindingtemplate.keyrefgrp")));
      out.write("\";\r\n");
      out.write("    \r\n");
      out.write("    var i18n_keyRefGrpAdd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.keyrefgroup.add")));
      out.write("\";\r\n");
      out.write("    var i18n_accesspointDescription=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.accesspoint.description")));
      out.write("\";\r\n");
      out.write("    var i18n_tmodelkey=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodel.key")));
      out.write("\";\r\n");
      out.write("    var i18n_tmodelInstanceParams=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.parameters")));
      out.write("\";\r\n");
      out.write("    var i18n_tmodelInstanceDescription=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.description")));
      out.write("\"; \r\n");
      out.write("    var i18n_tmodelInstanceDescription2=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.description2")));
      out.write("\"; \r\n");
      out.write("    var i18n_tmodelInstanceDescriptionAdd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.tmodelinstance.description.add")));
      out.write("\"; \r\n");
      out.write("    \r\n");
      out.write("    var i18n_overviewdoc=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.overviewurl")));
      out.write("\"; \r\n");
      out.write("    var i18n_overviewdocDescription=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.overviewurl.description")));
      out.write("\"; \r\n");
      out.write("    var i18n_overviewdocadd=\"");
      out.print(org.apache.commons.lang.StringEscapeUtils.escapeJavaScript(ResourceLoader.GetResource(session, "items.overviewurl.add")));
      out.write("\"; \r\n");
      out.write("    //items.overviewurl.description.add\r\n");
      out.write("    //items.name.add\r\n");
      out.write("    //items.overviewurl.description.add\r\n");
      out.write("    //items.bindingtemplate.add\r\n");
      out.write("    //items.bindingtemplate.description.add\r\n");
      out.write("//</script>");
    } catch (java.lang.Throwable t) {
      if (!(t instanceof javax.servlet.jsp.SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          try {
            if (response.isCommitted()) {
              out.flush();
            } else {
              out.clearBuffer();
            }
          } catch (java.io.IOException e) {}
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
