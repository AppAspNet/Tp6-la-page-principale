<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRechercheParGroupe.aspx.cs" Inherits="PrototypeGestionStagiaires.Presentation.StagiairesPresentation.WebFormRechercheParGroupe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
         <tr>
                <td>
                    Nom</td>
                <td>
                     <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Recherche" 
                        onclick="btRecherche_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Groupe</td>
                <td>
                    <asp:DropDownList ID="DropDownListGroupe" runat="server" 
                        DataTextField="Nom" DataValueField="Id">
                    </asp:DropDownList>
                  
                </td>
                <td>
                    <asp:Button ID="btRecherche" runat="server" Text="Recherche" 
                        onclick="btRecherche_Click" />
                </td>
            </tr>
            </table>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        >
        <Columns>
            <asp:BoundField DataField="Nom" HeaderText="Nom" SortExpression="Nom" />
            <asp:BoundField DataField="DateCréation" HeaderText="DateCréation" 
                SortExpression="DateCréation" />
            <asp:BoundField DataField="DateModificationString" HeaderText="DateModification" 
                SortExpression="DateModification" />
            <asp:BoundField DataField="IdGroupe" HeaderText="Groupe" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
