﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="FitnessApp.AdminLogin" %>

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
        <form method="get" action="index.html" class="form-horizontal">
          <div class="form-group">
            <div class="col-xs-12">
              <input type="text" placeholder="Username" class="form-control">
            </div>
          </div>
          <div class="form-group">
            <div class="col-xs-12">
              <input type="password" placeholder="Password" class="form-control">
            </div>
          </div>
          <div class="form-group">
     <%--       <div class="col-xs-12">
              <div class="checkbox-inline checkbox-custom pull-left">
                <input id="exampleCheckboxRemember" type="checkbox" value="remember">
                <label for="exampleCheckboxRemember" class="checkbox-muted text-muted">Remember me</label>
              </div>
              <div class="pull-right"><a href="forgot-password.html" class="inline-block form-control-static">Forgot a Passowrd?</a></div>
            </div>--%>
          </div>
          <button type="submit" class="btn-lg btn btn-primary btn-rounded btn-block">Sign in</button>
        </form>
        <hr>
        <p class="text-muted">Sign With Admin</p>
   <%--     <div class="clearfix">
          <div class="pull-left">
            <button type="button" style="width: 130px" class="btn btn-outline btn-rounded btn-primary"><i class="ti-facebook mr-5"></i> Facebook</button>
          </div>
          <div class="pull-right">
            <button type="button" style="width: 130px" class="btn btn-outline btn-rounded btn-info"><i class="ti-twitter-alt mr-5"></i> Twitter</button>
          </div>
        </div>--%>
        <hr>
        <div class="clearfix" style="margin-right: 72px;">
          <a href="TrainerLogin.aspx" class="inline-block pull-right">Sign In With Trainer</a>
          <br />
          <a href="CustomerLogin.aspx" class="inline-block pull-right" style="margin-right: -16px;">Sign In With Customer</a>

        </div>
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
