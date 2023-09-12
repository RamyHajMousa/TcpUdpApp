
# TCP/UDP Server-Klient Applikation med .NET och C#

Detta dokument beskriver stegen f�r att utveckla en TCP/UDP Server-Klient applikation med hj�lp av .NET och C#.

## Inneh�ll

1. [Uppdragskrav](#uppdragskrav)
2. [Tekniker som Anv�nds](#tekniker-som-anv�nds)
3. [Kom Ig�ng](#kom-ig�ng)
    - [F�ruts�ttningar](#f�ruts�ttningar)
4. [Server-Programmering](#server-programmering)
5. [Klient-Programmering](#klient-programmering)

---

## Uppdragskrav

- Servern m�ste implementera b�de TCP och UDP-sockets.
- Klienten ska kunna skicka b�de TCP- och UDP-f�rfr�gningar till servern.
- Servern ska kunna svara p� b�de TCP- och UDP-f�rfr�gningar fr�n klienten.
- B�de server- och klientprogrammen ska vara skrivna i C# och vara en del av samma kodbas eller projekt.
- Inkludera dokumentation som beskriver hur man bygger, konfigurerar och k�r applikationen.

---

## Tekniker som Anv�nds

- .NET 6
- C#

---

## Kom Ig�ng

### F�ruts�ttningar

1. Visual Studio Community 2022
2. .NET SDK

---

## Server-Programmering

1. Skapade en `TcpServer` klass f�r att hantera TCP-anslutningar.
2. Skapade en `UdpServer` klass f�r att hantera UDP-anslutningar.
3. B�da klasserna �rver fr�n en f�r�ldraklass `Server`.

```csharp
// Exempelkod f�r att starta TCP-server
TcpServer tcpServer = new TcpServer();
tcpServer.Start();
```

---

## Klient-Programmering

1. Skapade en `Client` klass med metoder `SendTcpMessage(string message)` och `SendUdpMessage(string message)` f�r att hantera meddelandes�ndning.
2. Byggde ett enkelt konsolbaserat anv�ndargr�nssnitt f�r anv�ndarinteraktion.

```csharp
// Exempelkod f�r att skicka TCP-meddelande
Client client = new Client();
client.SendTcpMessage("Hej, Server!");
```

---

## Testa och K�ra Applikationen Lokalt

F�r att k�ra applikationen lokalt p� din dator, f�lj dessa steg:

1. �ppna projektet i din IDE.
2. Bygg och k�r serverapplikationen.
3. Bygg och k�r klientapplikationen.

---
