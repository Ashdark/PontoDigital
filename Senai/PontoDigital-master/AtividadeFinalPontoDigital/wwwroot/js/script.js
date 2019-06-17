
    function myFunction() {
        // Variáveis
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById("myInput");
        filter = input.value.toUpperCase();
        table = document.getElementById("myTable");
        tr = table.getElementsByTagName("tr");
      
        // Inicia um loop pelas linhas, procurando pela palavra chave
      for (i = 1; i < tr.length; i++) {
          // Esconde todas as linhas
          tr[i].style.display = "none";
      
          td = tr[i].getElementsByTagName("td");
          for (var j = 0; j < td.length; j++) {
            cell = tr[i].getElementsByTagName("td")[j];
            if (cell) {
              if (cell.innerHTML.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
                break;
              } 
            }
          }
      }
      }
