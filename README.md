# TCP/UDP Server-Klient Console Applikation med .NET och C#

Detta dokument beskriver stegen för att utveckla en TCP/UDP Server-Klient console applikation med hjälp av .NET och C#. 

## Innehåll

1. [Uppdragskrav](#uppdragskrav)
2. [Tekniker som Används](#tekniker-som-används)
3. [Kom Igång](#kom-igång)
4. [Server-Programmering](#server-programmering)
5. [Klient-Programmering](#klient-programmering)

---

## Uppdragskrav

- Servern ska hantera både TCP och UDP-anslutningar.
- Klienten ska kunna skicka både TCP- och UDP-förfrågningar till servern.
- Servern ska kunna svara på både TCP- och UDP-förfrågningar från klienten.
- Båda applikationerna ska vara skrivna i C#.

---

## Tekniker som Används

- .NET 6
- C#

---

## Kom Igång

### För att köra applikationen lokalt:

1. **Öppna Projekt**: Öppna projektet i Visual Studio.
2. **Bygg Projektet**: Gå till `Build`-menyn och välj `Build Solution`.
3. **Starta Servern**: Högerklicka på serverprojektet i Solution Explorer och välj `Debug => Start Without Debugging`.
4. **Starta Klienten**: Efter att servern har startats, högerklicka på klientprojektet i Solution Explorer och välj `Debug => Start Without Debugging`.

---

## Server-Programmering

1. En `TcpServer` klass skapades för att hantera TCP-anslutningar.
2. En `UdpServer` klass skapades för att hantera UDP-anslutningar.
3. Båda klasserna ärver från en föräldraklass `Server` för gemensam funktionalitet.

---

## Klient-Programmering

1. En `Client` klass skapades med metoder `SendTcpMessage(string message)` och `SendUdpMessage(string message)` för att hantera meddelandesändning.
2. Ett konsolbaserat användargränssnitt skapades för att användaren ska kunna skicka meddelanden till servern.

---
---
