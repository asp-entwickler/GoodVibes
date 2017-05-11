$(document).ready(function () {

	//$.getScript("/Scripts/jquery.signalR-2.2.2.min.js").done(function () {
	var gvHostUrl = (window.location.protocol || "http:") + "//" + window.location.hostname + ":3333" + "/signalr/hubs";

	$.getScript(gvHostUrl).done(function (data) {

			hub = $.connection.crudHub;

			$.connection.hub.url = gvHostUrl;

			// 4 Test
			hub.client.broadcastMessage = function (name, message) {
				console.log("name: " + name + "     message: " + message);
			};

			$.connection.hub.start().done(function () {
				hub.server.send("SomeTerminal", "SignalR_Terminal_Message");
			});

		});

	});
//});