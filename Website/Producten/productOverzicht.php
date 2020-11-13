<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>DatabaseMedicijnen</title>
</head>
<body>
<table>
<thead>
            <tr>
                <td>ID</td>
                <td>Aantal</td>
                <td>Gewicht</td>
                <td>Datum_ontvangen</td>
                <td>Uiterste_datum</td>
            </tr>
        </thead>
        <tbody>
        <?php
          
            include_once '../Database/DatabaseHandler.php';
            $QueryTables = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';";
            $Tableresults = $Prodsconn -> query($QueryTables);
            while($row2 = $Tableresults -> fetch_array())
            { 
                $Query = "SELECT * FROM $row2[0]";
                $Prodresults = $Prodsconn -> query($Query);   
                while($row = $Prodresults -> fetch_assoc()) {
                    $ID = $row['ID'];
                    $Aantal = $row['Aantal'];
                    $Gewicht = $row['Gewicht'];
                    $DatumO = $row['Datum_ontvangen'];
                    $DatumU = $row['Uiterste_datum'];
                    echo "<tr>";
                    echo "<td> $ID </td>";
                    echo "<td> $Aantal </td>";
                    echo "<td> $Gewicht </td>";
                    echo "<td> $DatumO </td>";
                    echo "<td> $DatumU </td>";
                    echo "</tr>";
            }
        }
            
        ?>
            </tbody>
            </table>
</body>
</html>