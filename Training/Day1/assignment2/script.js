let count = 1;

$("#submitBtn").click(() => {
  let name = $("#name").val();
  let salary = $("#salary").val();
  let age = $("#age").val();
  let imgurl = $("#imageurl").val();
  console.log(name, salary, age, imgurl);
  var row = $("<tr>");
  row.html(`<td>${count++}</td>
    <td><img src="${imgurl}" alt="img"  width="50"></td>
    <td>${name}</td>
    <td>${salary}</td>
    <td>${age}</td>
    <td><button class="editBtn" type"submit">Edit</button></td>
    <td><button class="deleteBtn"type"submit">Delete</button></td>
 `);
  $("#table tbody").append(row);
});

$(document).on("click", ".editBtn", function () {
  var row = $(this).closest("tr");
  var cells = row.find("td");
  $("#name").val(cells.eq(2).text());
  $("#salary").val(cells.eq(3).text());
  $("#age").val(cells.eq(4).text());
  $("#imageurl").val(cells.eq(1).find("img").attr("src"));
  row.remove();
});

$(document).on("click", ".deleteBtn", function () {
  var row = $(this).closest("tr");
  row.remove();
});
