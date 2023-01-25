function getRandomInteger(min, max){
    const output = Math.floor(Math.random() * (max - min + 1) + min);
    return output;
}

function isInt(value) {
    if (isNaN(value)) {
      return false;
    }
    var x = parseFloat(value);
    return (x | 0) == x;
}

function createTable(size){
    const tab = document.getElementById("mulTable");
    const tabBody = document.createElement("tbody");

    tabBody.style.width = '200px';
    tabBody.style.border = '1px solid black';
    tabBody.style.borderCollapse = 'collapse';

    let contents = [];

    if (size < 5 || size > 20 || !isInt(size)){
        window.alert("The given size of the multiplication table was not appriopriate! It will automatically get changed to 8")
        size = 8;
    }

    var pElem = document.getElementById("mts");
    pElem.textContent = size;

    for (let i = 0; i < size; i++){
        const row = document.createElement('tr');

        for (let j = 0; j < size; j++){
            //let cell = row.insertCell();
            let cell;
            let cellText;

            if (i == 0){
                cell = document.createElement('th');
                cellText = getRandomInteger(1, 99);
                contents[j] = cellText;
            }
            else if (j == 0){
                cell = document.createElement('th');
                cellText = contents[i];
            }
            else{
                cell = document.createElement('td');
                cellText = contents[i] * contents[j];
                if (cellText % 2 == 0){
                    cell.classList.add('even');
                }
                else{
                    cell.classList.add('odd');
                }
            }

            cell.appendChild(document.createTextNode(cellText));
            cell.style.border = '1px solid black';
            cell.style.borderCollapse = 'collapse';
            row.appendChild(cell);
        }

        tabBody.appendChild(row);
    }

    tab.appendChild(tabBody);
}