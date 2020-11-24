<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
  * {
    box-sizing: border-box;
    }


  #myInput{
    width:100%;  
                padding-left: 1%;
                padding-top: 2%;
                padding-bottom: 2%;
                
                 background-color:#ebebeb;

                font-size: 140%;
                font-weight: bold;

                border-radius: 4px;
                border: 4px solid #0e4a36;

                color: black;
            }
            #myInput:hover{
                border-color:#21755a;
                background-color:#f5f5f5;
            }
            #myInput:focus{
                border-color:#21755a;
                background-color:white;
            }
  

  #Searchbarcont{
    padding: 10px;
    width:50%;
  }
  /*mytable*/
    #myTable {
      border-color:#58c4a0;
      border-collapse: collapse;
      width: 100%;
      border: 2px solid #58c4a0;
      font-size: 14px;
    }
    #myTable th{
      height:50px;

      padding: 5px;

      border: 8px solid #58c4a0;
      border-bottom: 8px solid #58c4a0;
      border-left: 3px solid #58c4a0;
      border-right: 3px solid #58c4a0;
      
    }

    #myTable th {
      text-align: left;

      padding: 5px;
    }

    #myTable td{

      padding: 5px;
      border: 2px solid #58c4a0;
      border-bottom: 4px solid #58c4a0;
      border-left: 3px solid #58c4a0;
      border-right: 3px solid #58c4a0;
    }
    #myTable tr {
      border-bottom: 1px solid #58c4a0;
    }

    #myTable tr.header, #myTable tr:hover {
      background-color: #f1f1f1;
    }

    #MainTableHead{
      height:50px;
      border: 1px solid #ddd;
    }
  /**/

  /*InvisTable*/
    .InvisTable {
      border-color:#58c4a0;
      border-collapse: collapse;
      width: 100%;
      border: 2px solid #58c4a0;
      font-size: 14px;
    }

    .InvisTable th{
      text-align: left;
      padding: 0px;
    }
    .InvisTable td{

      padding: 5px;
      border: 2px solid #58c4a0;
      border-bottom: 4px solid #58c4a0;
      border-left: 3px solid #58c4a0;
      border-right: 3px solid #58c4a0;
    }

    .InvisTable tr {
      border-bottom: 2px solid #58c4a0;
    }

    .InvisTable tr.header, .InvisTable tr:hover {
      background-color: #f1f1f1;
    }
  /**/
  
  .BTN-CONT{
    padding: 0px;
    height:48px;
    width:48px;
    border-radius: 0px;
    background-color:#58c4a0;
  }
  .HideContent{
    display:none;
    visibility: hidden;
  }

  #ColBut{
    background-color:#1f8563;

    font-size: 120%;
    font-weight: bold;

    line-height: 25px;
    border-radius: 8px;
    border: 4px solid #0e4a36;
  }
  #ColBut:hover{
    background-color:#1aad7c;
    color:#4f4f4f;
    border-color:#21755a;
  }

  #ColBut.ButtonActive{
    background-color: #0D5B41;
    color: white;
    border-color:#21755a;
  }


</style>
</head>
<body>

<div id = "Searchbarcont">
  <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Barcode..." title="Type in a name">
</div>


  <!--<table id="myTable">
    <tr id="MainTableHead">
      <th style="width:17.5%;">Barcode</th>
      <th style="width:17.5%;">Naam</th>
      <th style="width:12.5%;">Aantal</th>
      <th style="width:12.5%;">Gewicht</th>
      <th style="width:12.5%;">Datum ontvangen</th>
      <th style="width:12.5%;">Uiterste gebruiksdatum</th>
      <th style="width:12.5%;"></th>
    </tr>
    
  </table>-->
  <?php include_once 'Fetchprodinfo.php';?>


  <script src="Producten/Zoekfunctie.js"></script> 

</body>
</html>
