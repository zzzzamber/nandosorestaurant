// When the document is loaded, the DOMContentLoaded event occurs 
// We execute all our other logic after this occurs.
document.addEventListener("DOMContentLoaded", function () {
    console.log("DOM loaded and ready to go!");
    loadStudents();
});

// Used to load the student data - can actually do without this function
// if you are not doing anything else in the load.
function loadMySpecial() {
    MySpecialModule.getMySpecial(setupMySpecialTable);
}

// This is the function we pass into StudentModule as the callback
// It takes the data returned from the API call (studenList) and an input
function setupMySpecialTable(specialsList) {

    // Get a reference to the table body so we can add our rows in
    var specialsTable = document.getElementById("specialsList");

    // Loop through all the student/name objects 
    for (i = 0; i < specials.length; i++) {

        // Create row 
        var row = document.createElement('tr');

        // Add the columns in the row (td / data cells)
        var categorycol = document.createElement('td');
        categorycol.innerHTML = specials[i].Category;
        row.appendChild(categorynamecol);

        var dishnamecol = document.createElement('td');
        dishnamecol.innerHTML = specials[i].Dishname;
        row.appendChild(dishnamecol);

        var pricecol = document.createElement('td');
        pricecol.innerHTML = specials[i].Price;
        row.appendChild(pricecol);

        // Append the row to the end of the table
        specialsTable.appendChild(row);


    }

}