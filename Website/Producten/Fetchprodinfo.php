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
                echo '<td> <button type="button" class="collapsible"> V </button> </td>';
                echo '<div class="content">';
                echo '<p>AAAA</p>';
                echo '</div>';
            }
        }
            
    ?>
</tbody>

<script>
var coll = document.getElementsByClassName("collapsible");
var i;

for (i = 0; i < coll.length; i++) {
  coll[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var content = this.nextElementSibling;
    if (content.style.display === "block") {
      content.style.display = "none";
    } else {
      content.style.display = "block";
    }
  });
}
</script>