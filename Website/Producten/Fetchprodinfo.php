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

    .InvisHead{
        visibility: visible;
    }

    .activeA:after {
    content: "\2796"; /* Unicode character for "minus" sign (-) */
    }
    </style>
</head>
    <?php
        $QueryTables = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';";
        $Tableresults = $Prodsconn -> query($QueryTables);
        $AddHead = true;

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
                
                //Creates a New table with an invisable head, only to destroy the table later on to make way for
                //The collapsible panel. This is very inefficient, but the only bit seems to be the only way
                //So I do not care at this point as it is 1:28am in the morning and I've got to get some sleep!
                if($AddHead == true){
                    echo '<table id="myTable">';
                    echo '<tr id="MainTableHead">';
                    echo '<th style="width:100px;">Barcode</th>';
                    echo '<th style="width:100px;">Naam</th>';
                    echo '<th style="width:80px;">Aantal</th>';
                    echo '<th style="width:70px;">Gewicht</th>';
                    echo '<th style="width:100px;">Datum ontvangen</th>';
                    echo '<th style="width:150px;">Uiterste gebruiksdatum</th>';
                    echo '<th style="width:48px;height:48px;background-color:#58c4a0;border-radius:0px;"></th>';
                    $AddHead = false;
                } else{
                    echo '<table id="InvisTable">';
                    echo '<tr class="InvisHead">';
                    echo '<th class="InvisHead" style="width:100px;"></th>';
                    echo '<th class="InvisHead" style="width:100px;"></th>';
                    echo '<th class="InvisHead" style="width:80px;"></th>';
                    echo '<th class="InvisHead" style="width:70px;"></th>';
                    echo '<th class="InvisHead" style="width:100px;"></th>';
                    echo '<th class="InvisHead" style="width:150px;"></th>';
                    echo '<th class="InvisHead" style="width:48px;"></th>';
                }


                echo "</tr>";
                echo '<tbody> <tr>';
                echo "<td> $ID </td>";
                echo "<td> $row2[0] </td>";
                echo "<td> $Aantal </td>";
                echo "<td> $Gewicht mg </td>";
                echo "<td> $DatumO </td>";
                echo "<td> $DatumU </td>";
                echo '<td class="BTN-CONT" style="padding:0px;height:48px;width:48px;background-color:#58c4a0"> <div style:"background-color:#58c4a0"> <button id="ColBut" type="button" style="height:48px;width:48px;z-index: 1;"> + </button> </div> </td> </tr>';
                echo '</tbody> </table>'; //Escape out of the whole table and create a div
                echo "<div class='HideContent' style:'width:100%'>";
                echo "<form action='../Bestellen.php' method='post'>";
                echo '<button type="submit"';
                echo "value='";
                echo "$row2[0]";
                echo "' name='Product'>Bestellen</button>";
                echo "</form>";
                echo "</div>";
            }
        }
            
    ?>

    <script>
        document.body.addEventListener("click", event => {
            if (event.target.nodeName == "BUTTON") {
                var Button = event.target;
                var table = event.target.parentNode.parentNode.parentNode.parentNode.parentNode;
                var Collap = table.nextElementSibling;

                if (Collap.className == "ShowContent"){
                    //min
                    Collap.className = "HideContent";
                    Button.className = ""; 
                    Button.innerHTML = "+";
                } else {
                    //plus
                    Collap.className = "ShowContent";
                    Button.className = "ButtonActive"; 
                    Button.innerHTML = "-";
                }
            }
        });
    </script>
</tbody>
</html>

