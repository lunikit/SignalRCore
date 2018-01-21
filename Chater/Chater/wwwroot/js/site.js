
let hubUrl = '/chat';
let httpConnection = new signalR.HttpConnection(hubUrl);
let hubConnection = new signalR.HubConnection(httpConnection);

hubConnection.on("Send", function (data) {
    let elem = document.createElement("p");
    elem.appendChild(document.createTextNode(data));
    let firstElem = document.getElementById("chatroom").firstChild;
    document.getElementById("chatroom").insertBefore(elem, firstElem);
});

document.getElementById("sendBtn").addEventListener("click", function (e) {
    let message = document.getElementById("message").value;
    hubConnection.invoke("Send", message);
});

document.getElementById("sendBtnApi").addEventListener("click", function (e) {
    let message = document.getElementById("message").value;
    fetch('/api/chat/' + message, { method: 'POST' });
});

hubConnection.start();