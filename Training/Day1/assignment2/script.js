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
  $("#details").css("visibility","visible");
});

$(document).on("click", ".editBtn", function () {
  var row = $(this).closest("tr");
  var cells = row.find("td");
  var name = cells.eq(2).text();
  var salary = cells.eq(3).text();
  var age = cells.eq(4).text();
  var imgurl = cells.eq(1).find("img").attr("src");
  $("#submitBtn").css("visibility", "hidden");

  
  $("#name").val(name);
  $("#salary").val(salary);
  $("#age").val(age);
  $("#imageurl").val(imgurl);

  
  var editButton = row.find(".editBtn");
  editButton.text("Update").removeClass("editBtn").addClass("updateBtn");});

  $(document).on("click", ".updateBtn", function () {
    var row = $(this).closest("tr");
    var cells = row.find("td");
    var name = $("#name").val();
    var salary = $("#salary").val();
    var age = $("#age").val();
    var imgurl = $("#imageurl").val();
      
    cells.eq(2).text(name);
    cells.eq(3).text(salary);
    cells.eq(4).text(age);
    cells.eq(1).find("img").attr("src", imgurl);
     
    var updateButton = row.find(".updateBtn");
    updateButton.text("Edit").removeClass("updateBtn").addClass("editBtn");
  
    
    $("#name").val("");
    $("#salary").val("");
    $("#age").val("");
    $("#imageurl").val("");
    $("#submitBtn").css("visibility", "visible");

  });

$(document).on("click", ".deleteBtn", function () {
  var row = $(this).closest("tr");
  row.remove();
});
