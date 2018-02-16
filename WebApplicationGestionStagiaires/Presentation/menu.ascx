<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menu.ascx.cs" Inherits="WebApplicationGestionStagiaires.Presentation.menu" %>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" 
        StaticSubMenuIndent="16px"  >
        <Items>
            <asp:MenuItem NavigateUrl="~/WebFormApplication.aspx" Text="Application" 
                Value="Application"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Presentation/StagiairesPresentation/WebFormInterfaceMiseAJourStagiaires.aspx" 
                Text="Stagiaires" Value="Stagiaires"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Presentation/GroupesPresentation/WebFormGestionGroupes.aspx" 
                Text="Groupes" Value="Groupes"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Presentation/StagiairesPresentation/WebFormRechercheParGroupe.aspx" 
                Text="Recherche" Value="Recherche"></asp:MenuItem>
        </Items>
    </asp:Menu>