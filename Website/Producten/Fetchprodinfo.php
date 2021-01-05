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


<body>



</body>   
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
                $TotaalGewicht = $Aantal * $Gewicht;
                $Type = $row['Type'];
                $Leverancier = $row['Leverancier'];

                $CurrentYear = date("Y");
                
                $EersteLeverJaarSub = rand(3, 10);
                $EersteLeverMaand = rand(1, 12);
                $EersteLeverDag = rand(1,30);

                $EersteLeverJaar = $CurrentYear - $EersteLeverJaarSub;

                $EersteLever = "$EersteLeverJaar-$EersteLeverMaand-$EersteLeverDag";


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
                echo '<td class="BTN-CONT" style="height:48px;width:48px;"> <div> <button id="ColBut" type="button"  onclick="';
                echo 'Collapse(event)"';
                echo 'style="height:48px;width:48px;z-index: 1;"> + </button> </div> </td> </tr>';
                echo '</tbody> </table>'; //Escape out of the whole table and create a div
                echo "<div class='HideContent' id='Collapsible' style='width:100%'>";
                echo '<div>
                        <div class="InfoButtonsContainer">
                            <button class="tablinks ButtonActive" onclick="';
                            echo "openInfo(event, 'Merk')"; 
                            echo '">Merk</button>';

                            echo '<button class="tablinks" onclick="';
                            echo "openInfo(event, 'Totaal-Gewicht')";
                            echo '">Totaal Gewicht</button>';

                            echo '<button class="tablinks" onclick="';
                            echo "openInfo(event, 'Type')";
                            echo '">Type</button>';

                            echo '<button class="tablinks" onclick="';
                            echo "openInfo(event, 'Leverancier')";
                            echo '">Leverancier</button>';

                            echo '<button class="tablinks" onclick="';
                            echo "openInfo(event, 'Eerste-Levering')";
                            echo '">Eerste Levering</button>';

                        echo "</div>
                        
                        <div class='ExtraInfoContainer'>
                            <div class='tabcontent Merk' style='display:block'>
                                <div class='InfoCont'>
                                    <h3>Merk</h3>
                                    <p>$row2[0]</p>
                                </div>
                            </div>
                    
                            <div class='tabcontent Totaal-Gewicht' style='display:none'>
                                <div class='InfoCont'>
                                    <h3>Totaal Gewicht</h3>
                                    <p> $TotaalGewicht mg</p>
                                </div>
                            </div>
                    
                            <div class='tabcontent Type' style='display:none'>
                                <div class='InfoCont'> 
                                    <h3>Type</h3>
                                    <p>$Type</p>
                                </div>
                            </div>
                    
                            <div class='tabcontent Leverancier' style='display:none'>
                                <div class='InfoCont'>
                                    <h3>Leverancier</h3>
                                    <p>$Leverancier</p>
                                </div>
                            </div>
                    
                            <div class='tabcontent Eerste-Levering' style='display:none'>
                                <div class='InfoCont'>
                                    <h3>Eerste Levering</h3>
                                    <p>$EersteLever</p>
                                </div>
                            </div>
                        </div>
                    </div>";
                echo '<div>';
                echo "<form class='BestelForm' action='../Bestellen.php' method='post'>";
                echo '<button class="BestelBTN" type="submit"';
                echo "value='";
                echo "$row2[0]";
                echo "'name='Product'>Bestellen</button>";
                echo "</form>";
                echo "</div>";
                echo "</div>";
                echo "</div>";
            }
        }
            
    ?>

    <script>
    function openInfo(evt, prodInfo) {

        // Declare all variables
        var i, tabcontent, tablinks, SibDiv, Button;

        Button = evt.target;
        SibDiv = Button.parentNode.nextElementSibling; //Gets Sibling Div
        tabcontent = SibDiv.getElementsByClassName('tabcontent'); //Gets Sibling Div Children with class tabcontent
        tablinks = Button.parentNode.childNodes;
        
        for (i = 0; i < tabcontent.length; i++) { //Hide all tabContent elements
            tabcontent[i].style.display = "none";
        }

        // Get all elements with class="tablinks" and remove the class "active"
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = "tablinks";
        }

        // Show the current tab, and add an "active" class to the button that opened the tab
        var DisplayTarget = SibDiv.getElementsByClassName(prodInfo);
        for (k = 0; k < DisplayTarget.length; k++){
            DisplayTarget[k].style.display="block";
        }
        Button.className = "tablinks ButtonActive";
    }
    
    function Collapse(event){
        if (event.target.nodeName == "BUTTON") {
            var Button, Collap; 
            Button = event.target;
            Collap = Button.parentNode.parentNode.parentNode.parentNode.parentNode.nextElementSibling;

            if (Collap.className == "ShowContent"){
                //plus
                Collap.className = "HideContent";
                Button.className = ""; 
                Button.innerHTML = "+";
            } else {
                //min
                Collap.className = "ShowContent";
                Button.className = "ButtonActive"; 
                Button.innerHTML = "-";
            }
        }
    }

    var DefaultOpen = document.getElementsByClassName("defaultOpen");
    for (j = 0; j < DefaultOpen.length; j++){
        DefaultOpen[j].click();
    }
    
    </script>
</tbody>
</html>

