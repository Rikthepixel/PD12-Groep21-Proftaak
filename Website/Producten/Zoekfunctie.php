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
    <th style="width:40%;">ID</th>
    <th style="width:15%;">AANTAL</th>
    <th style="width:15%;">GEWICHT</th>
    <th style="width:15%;">DATUM ONTVANGEN</th>
    <th style="width:15%;">UITERSTE GEBRUIKDATUM</th>
  </tr>
  <tr>
    <td>15456513</td>
    <td>30</td>
    <td>200 mg</td>
    <td>05/11/2020</td>
    <td>17/08/2021</td>
  </tr>
  <tr>
    <td>9846521245</td>
    <td>9</td>
    <td>500 mg</td>
    <td>23/06/2020</td>
    <td>26/08/2022</td>
  </tr>
  <tr>
    <td>9864513</td>
    <td>33</td>
    <td>250 mg</td>
    <td>09/10/2020</td>
    <td>17/08/2022</td>
  </tr>
  <tr>
    <td>3123114</td>
    <td>28</td>
    <td>500 mg</td>
    <td>04/04/2020</td>
    <td>06/07/2021</td>
  </tr>
</table>

<script src="./medicijnen.js"></script> 

</body>
</html>
