<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainerSignUp.aspx.cs" Inherits="FitnessApp.TrainerSignUp" %>

<!DOCTYPE html>
<html lang="en" style="height: 100%">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Umega App - Login</title>
    <!-- PACE-->
    <link rel="stylesheet" type="text/css" href="../plugins/PACE/themes/blue/pace-theme-flash.css">
    <script type="text/javascript" src="../plugins/PACE/pace.min.js"></script>
    <!-- Bootstrap CSS-->
    <link rel="stylesheet" type="text/css" href="../plugins/bootstrap/dist/css/bootstrap.min.css">
    <!-- Fonts-->
    <link rel="stylesheet" type="text/css" href="../plugins/themify-icons/themify-icons.css">
    <!-- Primary Style-->
    <link rel="stylesheet" type="text/css" href="../build/css/first-layout.css">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries-->
    <!-- WARNING: Respond.js doesn't work if you view the page via file://--> 
    <!--[if lt IE 9]>
    <script type="text/javascript" src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script type="text/javascript" src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
  <body style="background-image: url(../build/images/backgrounds/16.jpg)" class="body-bg-full">
    <div class="container page-container">
      <div class="page-content">
        <div class="logo"><img src="../build/images/logo/logo-sm-light.png" alt="" width="80"></div>
        <form class="form-horizontal" runat="server" >
          <div class="form-group">
            <div class="col-xs-12">
              <input type="text" name="txtfirstname" id="txtfirstname" value=""  placeholder="First Name" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter First Name" ForeColor="Red" ControlToValidate="txtfirstname"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group">
            <div class="col-xs-12">
              <input type="text" name="txtlastname" id="txtlastname" value="" placeholder="Last Name" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Last Name" ForeColor="Red" ControlToValidate="txtlastname"></asp:RequiredFieldValidator>
            </div>
          </div>
               <div class="form-group">
            <div class="col-xs-12">
              <input type="text" name="txtmobileno" id="txtmobileno" value="" placeholder="Mobile No" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Mobile No" ForeColor="Red" ControlToValidate="txtmobileno"></asp:RequiredFieldValidator>
            </div>
          </div>
               <div class="form-group">
            <div class="col-xs-12">
              <input type="text" name="txtaddress" id="txtaddress" value="" placeholder="Address" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Address" ForeColor="Red" ControlToValidate="txtaddress"></asp:RequiredFieldValidator>
            </div>
          </div>
               <div class="form-group">
            <div class="col-xs-12">
              <input type="text" name="txtexpertise" id="txtexpertise" value="" placeholder="Expertise" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Expertise" ForeColor="Red" ControlToValidate="txtexpertise"></asp:RequiredFieldValidator>
            </div>
          </div>
                  <div class="form-group">
            <div class="col-xs-12">
              <input type="text" name="txtusername" id="txtusername" value="" placeholder="User Name" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter User Name" ForeColor="Red" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
            </div>
          </div>
                  <div class="form-group">
            <div class="col-xs-12">
              <input type="password" name="txtpassword" id="txtpassword" value="" placeholder="Password" class="form-control" runat="server">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter Password" ForeColor="Red" ControlToValidate="txtpassword"></asp:RequiredFieldValidator>
            </div>
          </div>
     <%--     <div class="form-group">
            <div class="col-xs-12">
              <div class="checkbox-inline checkbox-custom pull-left">
                <input id="exampleCheckboxRemember" type="checkbox" value="remember">
                <label for="exampleCheckboxRemember" class="checkbox-muted text-muted">Remember me</label>
              </div>
              <div class="pull-right"><a href="forgot-password.html" class="inline-block form-control-static">Forgot a Passowrd?</a></div>
            </div>
          </div>--%>
            <asp:Button ID="btnacccreate" class="btn-lg btn btn-primary btn-rounded btn-block" runat="server" Text="Create Account" OnClick="btnacccreate_Click" />
          <%--<button id="btnacccreate" type="submit" class="btn-lg btn btn-primary btn-rounded btn-block">Create Account</button>--%>
        </form>
        <%--<hr>--%>
        <%--<p class="text-muted">Sign With Trainer</p>--%>
 <%--       <div class="clearfix">
          <div class="pull-left">
            <button type="button" style="width: 130px" class="btn btn-outline btn-rounded btn-primary"><i class="ti-facebook mr-5"></i> Facebook</button>
          </div>
          <div class="pull-right">
            <button type="button" style="width: 130px" class="btn btn-outline btn-rounded btn-info"><i class="ti-twitter-alt mr-5"></i> Twitter</button>
          </div>
        </div>--%>
        <%--<hr>--%>
   <%--     <div class="clearfix">
         <a class="text-muted mb-0 pull-left">Want new account</a>
        </div>--%>
      </div>
    </div>
    <!-- Demo Settings start-->
    <div class="setting closed"><a href="javascript:;" class="setting-toggle fs-16"><i class="ti-palette text-white"></i></a>
      <h5 class="fs-16 mt-0 mb-20 text-white">Background Images</h5>
      <ul class="list-inline">
        <li><a href="javascript:;" data-bg="14.jpg" class="inline-block body-bg"><img src="../build/images/thumbnails/14.jpg" width="60" alt="" class="img-rounded"></a></li>
        <li><a href="javascript:;" data-bg="15.jpg" class="inline-block body-bg"><img src="../build/images/thumbnails/15.jpg" width="60" alt="" class="img-rounded"></a></li>
        <li><a href="javascript:;" data-bg="16.jpg" class="inline-block body-bg"><img src="../build/images/thumbnails/16.jpg" width="60" alt="" class="img-rounded"></a></li>
      </ul>
      <ul class="list-inline mb-0">
        <li><a href="javascript:;" data-bg="17.jpg" class="inline-block body-bg"><img src="../build/images/thumbnails/17.jpg" width="60" alt="" class="img-rounded"></a></li>
        <li><a href="javascript:;" data-bg="18.jpg" class="inline-block body-bg"><img src="../build/images/thumbnails/18.jpg" width="60" alt="" class="img-rounded"></a></li>
        <li><a href="javascript:;" data-bg="19.jpg" class="inline-block body-bg"><img src="../build/images/thumbnails/19.jpg" width="60" alt="" class="img-rounded"></a></li>
      </ul>
    </div>
    <!-- Demo Settings end-->
    <!-- jQuery-->
    <script type="text/javascript" src="../plugins/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap JavaScript-->
    <script type="text/javascript" src="../plugins/bootstrap/dist/js/bootstrap.min.js"></script>
    <!-- Custom JS-->
    <script type="text/javascript" src="../build/js/first-layout/extra-demo.js"></script>
  </body>
</html>
