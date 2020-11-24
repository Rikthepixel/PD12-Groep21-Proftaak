// JavaScript code 
function myFunction() {
    var input, filter, table, TableContainers, tr, td, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();

    TableContainers = document.getElementsByClassName("TableCont");

    for(m = 0; m < TableContainers.length; m++){
      table = TableContainers[m].getElementsByClassName("InvisTable");
      for(j = 0; j < table.length; j++){
        tr = table[j].getElementsByTagName("tr");
  
        for (i = 0; i < tr.length; i++) {
          td = tr[i].getElementsByTagName("td")[0];
  
          if (td) {
  
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
              TableContainers[m].style.display = "";
            } else {
              TableContainers[m].style.display = "none";
            }
            
          }       
        }
      }
    }
  }