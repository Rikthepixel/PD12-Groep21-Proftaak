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
                echo "<td> $row2[0] </td>";
                echo "<td> $Aantal </td>";
                echo "<td> $Gewicht </td>";
                echo "<td> $DatumO </td>";
                echo "<td> $DatumU </td>";
                /* echo '<td>'; 
                echo '<button type="button" class="collapsible"> V </button> </td>';
                echo '<tr class="content">';
                echo '<td> A </td>';
                echo '</tr>'; */
            }
        }         
    ?>
</tbody>
