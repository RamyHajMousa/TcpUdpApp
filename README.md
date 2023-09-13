# TCP/UDP Server-Klient Console Applikation med .NET och C#

Detta dokument beskriver stegen f�r att utveckla en TCP/UDP Server-Klient console applikation med hj�lp av .NET och C#. 

## Inneh�ll

1. [Uppdragskrav](#uppdragskrav)
2. [Tekniker som Anv�nds](#tekniker-som-anv�nds)
3. [Kom Ig�ng](#kom-ig�ng)
4. [Server-Programmering](#server-programmering)
5. [Klient-Programmering](#klient-programmering)

---

## Uppdragskrav

- Servern ska hantera b�de TCP och UDP-anslutningar.
- Klienten ska kunna skicka b�de TCP- och UDP-f�rfr�gningar till servern.
- Servern ska kunna svara p� b�de TCP- och UDP-f�rfr�gningar fr�n klienten.
- B�da applikationerna ska vara skrivna i C#.

---

## Tekniker som Anv�nds

- .NET 6
- C#

---

## Kom Ig�ng

### F�r att k�ra applikationen lokalt:

1. **�ppna Projekt**: �ppna projektet i Visual Studio.
2. **Bygg Projektet**: G� till `Build`-menyn och v�lj `Build Solution`.
3. **Starta Servern**: H�gerklicka p� serverprojektet i Solution Explorer och v�lj `Debug => Start Without Debugging`.
4. **Starta Klienten**: Efter att servern har startats, h�gerklicka p� klientprojektet i Solution Explorer och v�lj `Debug => Start Without Debugging`.

---

## Server-Programmering

1. En `TcpServer` klass skapades f�r att hantera TCP-anslutningar.
2. En `UdpServer` klass skapades f�r att hantera UDP-anslutningar.
3. B�da klasserna �rver fr�n en f�r�ldraklass `Server` f�r gemensam funktionalitet.

---

## Klient-Programmering

1. En `Client` klass skapades med metoder `SendTcpMessage(string message)` och `SendUdpMessage(string message)` f�r att hantera meddelandes�ndning.
2. Ett konsolbaserat anv�ndargr�nssnitt skapades f�r att anv�ndaren ska kunna skicka meddelanden till servern.

---
---
