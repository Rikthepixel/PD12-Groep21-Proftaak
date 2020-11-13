<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

    <style>
      .collapsible {
    background-color: #777;
    color: white;
    cursor: pointer;
    padding: 18px;
    width: 100%;
    border: none;
    text-align: left;
    outline: none;
    font-size: 15px;
    }

    .activeA, .collapsible:hover {
        background-color: #555;
    }

    .content {
        padding: 0 18px;
        display: none;
        overflow: hidden;
        background-color: #f1f1f1;
    }
    .collapsible:after {
    content: '\02795'; /* Unicode character for "plus" sign (+) */
    font-size: 13px;
    color: white;
    float: right;
    margin-left: 5px;
    }

    .activeA:after {
    content: "\2796"; /* Unicode character for "minus" sign (-) */
    }
    </style>
</head>
<tbody>

    <?php
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

                echo '<tr class="CollandDecoll">';
                echo "<td> $ID </td>";
                echo "<td> $row2[0] </td>";
                echo "<td> $Aantal </td>";
                echo "<td> $Gewicht </td>";
                echo "<td> $DatumO </td>";
                echo "<td> $DatumU </td>";
                echo '<td> <button type="button" class="collapsible"> V </button> </td>';
                echo '<div class="content">';
                echo '<p>AAAA</p>';
                echo '</div>';
            }
        }
            
    ?>
    <script>
        var Colls = document.getElementsByClassName('CollandDecoll');
        
        function changeContent() {

        }
    </script>
</tbody>
</html>

