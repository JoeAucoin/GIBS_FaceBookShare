<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="GIBS.Modules.GIBS_FaceBookShare.Settings" %>


<!-- uncomment the code below to start using the DNN Form pattern to create and update settings -->
 

<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %>

	<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"><%=LocalizeString("BasicSettings")%></a></h2>
	<fieldset>


        <div class="dnnFormItem">
            <dnn:Label ID="lblToken" runat="server" /> 
 
            <asp:TextBox ID="txtToken" runat="server" />
        </div>
		
		
        <div class="dnnFormItem">
            <dnn:Label ID="lblContent" runat="server" /> 
 
            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" />
        </div>		

    </fieldset>


