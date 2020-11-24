<!DOCTYPE html>
<html lang="en">
<head>
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
                
                //Creates a New table with an invisable head, only to destroy the table later to make way for
                //The collapsible panel. This is very inefficient, but it seems to be the only way
                //So I do not care at this point as it is 1:28am in the morning and I've got to get some sleep!
                echo '<div class="TableCont">';
                echo '<table class="InvisTable">';
                echo '<tr class="InvisHead">';
                echo '<th class="InvisHead" style="width:100px;"></th>';
                echo '<th class="InvisHead" style="width:100px;"></th>';
                echo '<th class="InvisHead" style="width:80px;"></th>';
                echo '<th class="InvisHead" style="width:70px;"></th>';
                echo '<th class="InvisHead" style="width:100px;"></th>';
                echo '<th class="InvisHead" style="width:150px;"></th>';
                echo '<th class="InvisHead" style="width:48px;"></th>';
                echo "</tr>";
                echo '<tbody> <tr>';
                echo "<td> $ID </td>";
                echo "<td> $row2[0] </td>";
                echo "<td> $Aantal </td>";
                echo "<td> $Gewicht mg </td>";
                echo "<td> $DatumO </td>";
                echo "<td> $DatumU </td>";
                echo '<td class="BTN-CONT" style="border-radius:4px;height:48px;width:48px;"> <div> <button id="ColBut" type="button" style="height:48px;width:48px;z-index: 1;"> + </button> </div> </td> </tr>';
                echo '</tbody> </table>'; //Escape out of the whole table and create a div
                echo "<div class='HideContent' id='Collapsible' style='width:100%'>";
                echo "<form action='../Bestellen.php' method='post'>";
                echo '<button type="submit"';
                echo "value='";
                echo "$row2[0]";
                echo "' name='Product'>Bestellen</button>";
                echo "</form>";
                echo "</div>";
                echo "</div>";
            }
        }
            
    ?>

    <script>
        document.body.addEventListener("click", event => {
            if (event.target.nodeName == "BUTTON") {
                var Button = event.target;
                var ButtonTD = event.target.parentNode.parentNode;
                var table = event.target.parentNode.parentNode.parentNode.parentNode.parentNode;
                var Collap = table.nextElementSibling;

                if (Collap.className == "ShowContent"){
                    //min

                    ButtonTD.style.borderTopLeftRadius = "4px";
                    ButtonTD.style.borderBottomLeftRadius = "4px";
                    ButtonTD.style.borderTopRightRadius = "0px";
                    ButtonTD.style.borderBottomLeftRadius = "0px";
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

