<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Epicobox.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/carousel.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
    <link href="Content/footer.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="home">
        <div class="text">Dettagli della box</div>
        <div >
            <asp:Label ID="Label1" class="d-block my-5 w-25 fs-6 fw-bold text-center mx-auto   rounded-pill text text-bg-warning" runat="server" Text="Articolo aggiunto al carrello"></asp:Label>
        </div>
        <div class="w-75 rounded-2 border border-3 border-secondary text mx-auto py-5">

            <asp:Image ID="imageBox" runat="server" class="w-100 mb-3"/>
            <h1 id="Nome" runat="server" class="fw-bold"></h1>
            <p class="text-end display-6"><span id="Prezzo" runat="server" class="display-4"></span> cad.</p>
            <p id="DescrizioneLunga" runat="server"></p>
            <p class="text-end">Dal: <span id="dataInizio" runat="server" class="fw-semibold"></span> - al: <span id="dataFine" runat="server" class="fw-semibold"></span></p>     
            <p>Location: <span id="location" runat="server" class="fst-italic"></span></p>
            <p>Categoria: <span id="categoria" runat="server" class="fst-italic"></span></p>
            <div class="text-end d-flex justify-content-end align-items-center">
                <asp:DropDownList ID="DropDownList1" class="bg-warning rounded-2 mx-2 " runat="server">
                    <asp:ListItem  Value="1" Text="1" Selected="True"></asp:ListItem>
                    <asp:ListItem  Value="2" Text="2"></asp:ListItem>
                    <asp:ListItem  Value="3" Text="3"></asp:ListItem>
                    <asp:ListItem  Value="4" Text="4"></asp:ListItem>
                    <asp:ListItem  Value="5" Text="5"></asp:ListItem>
                </asp:DropDownList>
                <asp:LinkButton ID="Button1" runat="server" class="btn btn-warning fs-4 fw-semibold px-4" onclick="Button1_Click" >Aggiungi al carrello <i class='bx bx-cart icon fs-3'></i></asp:LinkButton>
            </div>          
        </div>

        <div>
            <h2 class="text mt-4 fw-semibold">...qualche dettaglio in più</h2>
            <div class="slider-container pb-2">

                <div class="slider-content">

                    <div class="slider-single">
                        <asp:Image ID="image1" runat="server" class="slider-single-image rounded-2" />
                        <h1 class="slider-single-title text">Your</h1>
                        <a class="slider-single-likes" href="javascript:void(0);">
                            <i class="fa fa-heart"></i>
                            <p class="text px-2">1,152</p>
                        </a>
                    </div>

                    <div class="slider-single">
                        <asp:Image ID="image2" runat="server" class="slider-single-image rounded-2" />
                        <h1 class="slider-single-title text">Next</h1>
                        <a class="slider-single-likes" href="javascript:void(0);">
                            <i class="fa fa-heart"></i>
                            <p class="text px-2">1,247</p>
                        </a>
                    </div>

                    <div class="slider-single">
                        <asp:Image ID="image3" runat="server" class="slider-single-image rounded-2" />
                        <h1 class="slider-single-title text">Xperience</h1>
                        <a class="slider-single-likes" href="javascript:void(0);">
                            <i class="fa fa-heart"></i>
                            <p class="text px-2">926</p>
                        </a>
                    </div>

                    <div class="slider-single">
                        <asp:Image ID="image4" runat="server" class="slider-single-image rounded-2" />
                        <h1 class="slider-single-title text text-center">Super Promo</h1>
<%--                        <a class="slider-single-likes" href="javascript:void(0);">
                            <i class="fa fa-heart"></i>
                            <p class="text px-2">926</p>
                        </a>--%>
                    </div>

                </div>
            </div>

        </div>
            <footer id="footerr" class="footer-distributed">
  <div class="footer-left">
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
<script src="Scripts/carousel.js"></script>
</asp:Content>

