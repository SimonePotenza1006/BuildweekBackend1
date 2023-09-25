<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Epicobox.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/StyleSheet1cart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="home">
        <div class="text">Riepilogo carrello</div>
        <div class="text text-center fs-3 fst-italic p-4" id="lblCart" runat="server">Il tuo carrello è vuoto</div>
        <div runat="server" id="Cart1" class="w-75 mx-auto p-3">
            <div class="container-fluid" id="header" runat="server">
                <div class="row w-100 border border-secondary bg-white rounded-2">
                    <div class="d-flex   flex-sm-row justify-content-evenly align-items-center  " style="background: lightgrey">
                        <div class="col-2 text-center">
                            <strong>Prodotto</strong>
                        </div>
                        <div class="col-9 d-flex flex-column flex-md-row  justify-content-evenly align-items-center p-2">
                            <div class="col text-center">
                                <strong>Nome Xperience</strong>

                            </div>

                            <div class="col text-center ">
                                <strong>Prezzo</strong>
                            </div>
                            <div class="col text-center ">
                                <strong>Quantità</strong>


                            </div>
                            <div class="col text-center">
                                <strong>Elimina</strong>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="Epicobox.Prodotto">

                <ItemTemplate>
                    <div class="container-fluid">
                        <div class="row w-100 border border-secondary bg-white rounded-2">
                            <div class="d-flex   flex-sm-row justify-content-evenly align-items-center  ">
                                <div class="col-2 text-center">
                                    <img id="img" class="w-100 mt-1 mb-1 rounded-2 " src="Content/Img/<%# Item.ImageBox %>" alt="Alternate Text" />
                                </div>
                                <div class="col-9 d-flex flex-column flex-md-row  justify-content-evenly align-items-center p-2">
                                    <div class="col text-center">
                                        <strong><%# Item.Nome %></strong>
                                        <p class="text-secondary"><%# Item.DescrizioneBreve %></p>
                                    </div>

                                    <div class="col text-center ">
                                        <strong><%# string.Format("{0:C}", Item.Prezzo) %></strong>
                                    </div>
                                    <div class="col text-center ">
                                        <asp:LinkButton ID="Remove" runat="server" Text='<i class="bx bx-minus text-secondary"></i>' OnClick="Remove_Click" CommandArgument='<%# Item.IdEsperienza %>' />
                                        <span><%# Item.Quantity %></span>
                                        <asp:LinkButton ID="Add" runat="server" Text='<i class="bx bx-plus text-secondary"></i>' OnClick="Add_Click" CommandArgument='<%# Item.IdEsperienza %>' />
                                    </div>
                                    <div class="col text-center">
                                        <asp:LinkButton ID="btnElimina" runat="server" Text='<i class="bx bx-trash text-danger"></i>' OnClick="btnElimina_Click" CommandArgument='<%# Item.IdEsperienza %>' />
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        
        <div >
            <asp:Label ID="Label1" class="d-block my-5 w-25 fs-6 fw-bold text-center mx-auto   rounded-pill text text-bg-warning" runat="server" Text="Sconto del 30% applicato al carrello"></asp:Label>
        </div>

        <div class="d-flex justify-content-between py-3 text">
            <h5 class="fs-3">Totale <span runat="server" id="totaleCarrello">€ 0,00</span></h5>
            <div >
                <asp:Label ID="Label2" visible="false" class="d-block my-5 fs-6 fw-bold text-center mx-auto   rounded-pill text text-bg-success" runat="server" Text="Grazie per il tuo ordine"></asp:Label>
            </div>
            <div>
                <asp:Button class="btn btn-primary me-3" ID="Button2" runat="server" Text="Concludi l'acquisto" OnClick="Button2_Click" />
                <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Svuota carrello" OnClick="Button1_Click" />
            </div>
        </div>
                       <footer id="footerr" class="footer-distributed position-absolute bottom-0">
  <div class="footer-left ">
    <h3>Gift<span>-X</span></h3>

    <p class="footer-links">
      <a href="#" class="link-1">Home</a>

      <a href="#">Blog</a>

      <a href="#">Pricing</a>

      <a href="#">About</a>

      <a href="#">Faq</a>

      <a href="#">Contact</a>
    </p>

    <p class="footer-company-name">Gift-X © 2023</p>
  </div>

  <div class="footer-center">
    <div>
      <i class="fa fa-map-marker"></i>
      <p><span>Sottoscala, 4 Private Drive</span> Little Whinging, Surrey</p>
    </div>

    <div>
      <i class="fa fa-phone"></i>
      <p>+39 333.1112223</p>
    </div>

    <div>
      <i class="fa fa-envelope"></i>
      <p><a href="mailto:support@company.com">support@giftx.com</a></p>
    </div>
  </div>

                   <div class="footer-right">
  <p class="footer-company-about">
      <h5>Progetto BuildWeek Epicode</h5>
    <h5>Chi siamo</h5>
         <hr> <i class="fab fa-linkedin"></i>
    <a class="anchor ms-1" href="https://www.linkedin.com/in/paolo-manca-developer/" target="_blank"> Paolo Manca </a>  <br />
      <i class="fab fa-linkedin"></i>
     <a class="anchor ms-1" href="https://www.linkedin.com/in/federico-maso-full-stack-developer/" target="_blank"> Federico Maso </a> <br />
      <i class="fab fa-linkedin"></i>
      <a class="anchor ms-1" href="https://www.linkedin.com/in/erica-diana-full-stack-developer/" target="_blank"> Erica Diana </a> <br />
      <i class="fab fa-linkedin"></i>
      <a class="anchor ms-1" href="https://www.linkedin.com/in/raffaeleianniello-webdeveloper/" target="_blank"> Raffaele Iannello </a>  <br />
      <i class="fab fa-linkedin"></i>
      <a class="anchor ms-1" href="https://www.linkedin.com/in/simone-potenza-front-end-developer/" target="_blank"> Simone Potenza </a> <br />
  </p>
</div>
</footer>
    </section>
</asp:Content>
