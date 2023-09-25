<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Epicobox.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <section class="home">
        <div class="text text-center pt-5 fs-1">Benvenuto su Gift Xperience</div>
     <div class="wrapper mx-auto my-5">
  <div class="title-text">
    <div class="title login">Accedi</div>
    <div class="title signup">Registrati</div>
  </div>
  <div class="form-container">
    <div class="slide-controls">
      <input type="radio" name="slide" id="login" checked>
      <input type="radio" name="slide" id="signup">
      <label for="login" class="slide login">Login</label>
      <label for="signup" class="slide signup">Signup</label>
      <div class="slider-tab"></div>
    </div>
    <div class="form-inner">
      <div class="form login">
        <div class="field">
          
            <asp:TextBox ID="LoginUsername" runat="server" placeholder="Username"></asp:TextBox>
        </div>
        <div class="field">
  
            <asp:TextBox ID="LoginPassword" TextMode="Password" runat="server" placeholder="Password"></asp:TextBox>
        </div>
        
        <div class="field btn">
          <div class="btn-layer"></div>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
        <div class="signup-link w-100">Non sei ancora dei nostri? <a href="#">Registrati ora</a></div>
      </div>
      <div class="form signup">
        <div class="field">
          <asp:TextBox ID="SignupUsername" runat="server" placeholder="Username"></asp:TextBox> 
        </div>
        <div class="field">
          <asp:TextBox ID="SignupPassword" TextMode="Password" runat="server" placeholder="Password"></asp:TextBox>
        </div>
        
        <div class="field btn">
          <div class="btn-layer"></div>
          <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
        </div>
      </div>
    </div>
  </div>
</div>
        <div class="text-center mt-5 fs-4">
            <asp:label runat="server" id="lblMessage" ForeColor="DarkRed" >Utente non trovato. Riprova o esegui il SignUp</asp:label>
        </div>
</section>
    <script src="Scripts/login.js"></script>

</asp:Content>
