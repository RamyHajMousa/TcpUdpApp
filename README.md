
# TCP/UDP Server-Klient Applikation med .NET och C#

Detta dokument beskriver stegen för att utveckla en TCP/UDP Server-Klient applikation med hjälp av .NET och C#.

## Innehåll

1. [Uppdragskrav](#uppdragskrav)
2. [Tekniker som Används](#tekniker-som-används)
3. [Kom Igång](#kom-igång)
    - [Förutsättningar](#förutsättningar)
4. [Server-Programmering](#server-programmering)
5. [Klient-Programmering](#klient-programmering)

---

## Uppdragskrav

- Servern måste implementera både TCP och UDP-sockets.
- Klienten ska kunna skicka både TCP- och UDP-förfrågningar till servern.
- Servern ska kunna svara på både TCP- och UDP-förfrågningar från klienten.
- Både server- och klientprogrammen ska vara skrivna i C# och vara en del av samma kodbas eller projekt.
- Inkludera dokumentation som beskriver hur man bygger, konfigurerar och kör applikationen.

---

## Tekniker som Används

- .NET 6
- C#

---

## Kom Igång

### Förutsättningar

1. Visual Studio Community 2022
2. .NET SDK

---

## Server-Programmering

1. Skapade en `TcpServer` klass för att hantera TCP-anslutningar.
2. Skapade en `UdpServer` klass för att hantera UDP-anslutningar.
3. Båda klasserna ärver från en föräldraklass `Server`.

```csharp
// Exempelkod för att starta TCP-server
TcpServer tcpServer = new TcpServer();
tcpServer.Start();
```

---

## Klient-Programmering

1. Skapade en `Client` klass med metoder `SendTcpMessage(string message)` och `SendUdpMessage(string message)` för att hantera meddelandesändning.
2. Byggde ett enkelt konsolbaserat användargränssnitt för användarinteraktion.

```csharp
// Exempelkod för att skicka TCP-meddelande
Client client = new Client();
client.SendTcpMessage("Hej, Server!");
```

---

## Testa och Köra Applikationen Lokalt

För att köra applikationen lokalt på din dator, följ dessa steg:

1. Öppna projektet i din IDE.
2. Bygg och kör serverapplikationen.
3. Bygg och kör klientapplikationen.

---

