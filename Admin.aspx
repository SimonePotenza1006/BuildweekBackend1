<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Epicobox.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="home">
        <div class="text">Pagina per la gestione delle Xperience</div>
        <div class="container border border-3 p-5 my-4 rounded-2 border-secondary">

            <div class="mb-3 d-flex flex-column mb-0">
                <asp:Label for="nomeEsperienza" runat="server" class="form-label text fs-5 p-0 m-0">Inserisci il nome dell'Esperienza</asp:Label>
                <asp:TextBox class="form-control" ID="nomeEsperienza" runat="server"></asp:TextBox>

                <asp:Label for="descrizioneBreve" runat="server" class="form-label text fs-5 p-0 m-0 mt-2">Inserisci una breve descrizione</asp:Label>
                <asp:TextBox class="form-control" ID="descrizioneBreve" runat="server"></asp:TextBox>

                <asp:Label for="descrizioneLunga" runat="server" class="form-label text fs-5 p-0 m-0 mt-2">Inserisci una descrizione più approfondita</asp:Label>
                <asp:TextBox class="form-control" ID="descrizioneLunga" runat="server"></asp:TextBox>

                <asp:Label for="prezzo" runat="server" class="form-label text fs-5 p-0 m-0 mt-2">Inserisci il Prezzo</asp:Label>
                <asp:TextBox class="form-control" ID="prezzo" runat="server"></asp:TextBox>

                <asp:Label for="dataInizio" runat="server" class="form-label text fs-5 p-0 m-0 mt-2">Inserisci la Data di Inizio</asp:Label>
                <asp:TextBox TextMode="Date" class="form-control" ID="dataInizio" runat="server"></asp:TextBox>

                <asp:Label for="dataFine" runat="server" class="form-label text fs-5 p-0 m-0 mt-2">Inserisci la Data di Fine</asp:Label>
                <asp:TextBox TextMode="Date" class="form-control" ID="dataFine" runat="server"></asp:TextBox>
                <div class="d-flex w-100 justify-content-between mt-4">
                <asp:Label for="DropDownList1" runat="server" class="form-label d-flex text fs-5 p-0 m-0">Selezionare la Location</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" class="w-25">

                    <asp:ListItem Value="1" Text="Italia" Selected="True"></asp:ListItem>

                    <asp:ListItem Value="2" Text="Europa"></asp:ListItem>

                    <asp:ListItem Value="3" Text="Mondo"></asp:ListItem>

                </asp:DropDownList>

                <asp:Label for="DropDownList2" runat="server" class="form-label text fs-5 p-0 m-0 d-flex">Selezionare la Categoria</asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" class="w-25">

                    <asp:ListItem Value="1" Text="Soggiorni" Selected="True"></asp:ListItem>

                    <asp:ListItem Value="2" Text="Benessere"></asp:ListItem>

                    <asp:ListItem Value="3" Text="Gourmet"></asp:ListItem>

                    <asp:ListItem Value="4" Text="Motori"></asp:ListItem>

                    <asp:ListItem Value="5" Text="Sport & Avventura"></asp:ListItem>

                    <asp:ListItem Value="6" Text="Idee Regalo"></asp:ListItem>

                    <asp:ListItem Value="7" Text="Tempo Libero"></asp:ListItem>

                    <asp:ListItem Value="8" Text="Offerte"></asp:ListItem>

                </asp:DropDownList>
                </div>
                <div class="d-flex w-100 align-items-center mt-4">
                <asp:Label runat="server" class="form-label w-25 text fs-5 p-0 m-0">Caricare Immagine Principale</asp:Label>

                <asp:FileUpload ID="fileUpload1" runat="server" class="form-control w-75"></asp:FileUpload>
                </div>
                <div class="d-flex w-100 align-items-center mt-4">
                <asp:Label runat="server" class="form-label w-25 text fs-5 p-0 m-0">Caricare Seconda Immagine</asp:Label>

                <asp:FileUpload ID="fileUpload2" runat="server" class="form-control w-75"></asp:FileUpload>
                </div>
                <div class="d-flex w-100 align-items-center mt-4">
                <asp:Label runat="server" class="form-label w-25 text fs-5 p-0 m-0">Caricare Terza Immagine</asp:Label>

                <asp:FileUpload ID="fileUpload3" runat="server" class="form-control w-75"></asp:FileUpload>
                </div>
                <div class="d-flex w-100 align-items-center mt-4">
                <asp:Label runat="server" class="form-label w-25 text fs-5 p-0 m-0">Caricare Quarta Immagine</asp:Label>

                <asp:FileUpload ID="fileUpload4" runat="server" class="form-control w-75"></asp:FileUpload>
                </div>
                <div class="d-flex w-100 align-items-center mt-4">
                <asp:Label runat="server" class="form-label w-25 text fs-5 p-0 m-0">Caricare Quinta Immagine</asp:Label>

                <asp:FileUpload ID="fileUpload5" runat="server" class="form-control w-75"></asp:FileUpload>
                </div>
                <div class="d-flex w-100 justify-content-evenly pt-5">
                    <asp:Button ID="aggiungi" runat="server" Text="Aggiungi Esperienza" OnClick="aggiungiEsperienza" class="btn btn-primary w-25 fs-4 fw-semibold" />
                    <asp:Button ID="modifica" runat="server" Text="Modifica Esperienza" OnClick="modifica_Click" class="btn btn-warning w-25 fs-4 fw-semibold" />
                    <asp:Button ID="elimina" runat="server" Text="Elimina Esperienza" OnClick="elimina_Click" class="btn btn-danger w-25 fs-4 fw-semibold" />
                </div>  

            </div>

        </div>
    </section>

</asp:Content>
