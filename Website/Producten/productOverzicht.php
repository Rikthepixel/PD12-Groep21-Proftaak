<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
  * {
    box-sizing: border-box;
    }

  #myInput {
    background-position: 10px 10px;
    background-repeat: no-repeat;
    width: 100%;
    font-size: 16px;
    padding: 12px 20px 12px 40px;
    border: 1px solid #ddd;
    margin-bottom: 12px;
  }

  #myTable {
    border-collapse: collapse;
    width: 100%;
    border: 1px solid #ddd;
    font-size: 18px;
  }

  #myTable th, #myTable td {
    text-align: left;
    padding: 12px;
  }

  #myTable tr {
    border-bottom: 1px solid #ddd;
  }

  #myTable tr.header, #myTable tr:hover {
    background-color: #f1f1f1;
  }
</style>
</head>
<body>

  <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Search for names.." title="Type in a name">

  <table id="myTable">
    <tr class="header">
      <th style="width:20%;">Barcode</th>
      <th style="width:20;"> Naam</th>
      <th style="width:15%;">Aantal</th>
      <th style="width:15%;">Gewicht</th>
      <th style="width:15%;">Datum ontvangen</th>
      <th style="width:15%;">Uiterste gebruiksdatum</th>
    </tr>
      <?php include_once 'Fetchprodinfo.php';?>
  </table>


  <script src="./Zoekfunctie.js"></script> 

</body>
</html>
