var BlazorScrollToId = function (id) {
    debugger;
    const element = document.getElementById(id);
    if (element instanceof HTMLElement) {
        element.scrollIntoView({
            behavior: "smooth",
            block: "start",
            inline: "nearest"
        });
    }
}

function copyToClipboard(text) {
    var input = document.body.appendChild(document.createElement("input"));
    input.value = text;
    input.focus();
    input.select();
    document.execCommand('copy');
    input.parentNode.removeChild(input);
}

function highlightTreeItem(currElement, over) {
    //get attribute value and set hover color
    var element = currElement.getAttribute("userCreated");

    // TODO: yellow, blue, and gray come from _host.cshtml, should use class in css instead?
    if (element == "true") {
        currElement.style.backgroundColor = over ? yellow : blue;
    } else {
        currElement.style.backgroundColor = over ? blue : gray;
    }
}

// tree
window.PlaySound = function () {
    document.getElementById('sound').play();
}
