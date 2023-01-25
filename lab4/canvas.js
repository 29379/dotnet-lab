function getMousePosition(canvas) {
    if(mouseOver) {
        let rectangle = canvas.getBoundingClientRect();
        let canvasEvent = window.event;
        return {
            x: canvasEvent.clientX - rectangle.left,
            y: canvasEvent.clientY - rectangle.top
        };
    }
    else return null;
}

function clearCanvas(canvas) {
    mouseOver = false;
    const context = canvas.getContext('2d');
    context.clearRect(0, 0, canvas.width, canvas.height);
    context.beginPath();
}

function drawLines(canvas) {
    const context = canvas.getContext('2d');
    context.lineWidth = 1;
    context.strokeStyle = 'steelblue';

    let position = getMousePosition(canvas);
    context.clearRect(0, 0, canvas.width, canvas.height);
    context.beginPath();

    let canvasCorners = [[0, 0], [0, canvas.height], [canvas.width, 0], [canvas.width, canvas.height]];
    canvasCorners.forEach(pair => {
        context.moveTo(position.x, position.y);
        context.lineTo(pair[0], pair[1]);
    });
    
    context.stroke();
}