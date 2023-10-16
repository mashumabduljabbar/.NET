# .NET

## 1. Apa itu .NET dan Bahasa Pemrograman apa yang digunakan

**.NET** adalah sebuah platform pengembangan perangkat lunak yang dibuat oleh Microsoft. Ini mencakup sejumlah besar perpustakaan, framework, dan bahasa pemrograman yang dapat digunakan untuk pengembangan aplikasi. Beberapa bahasa pemrograman yang dapat digunakan dengan .NET termasuk C#, F#, dan Visual Basic.

## 2. Persiapan

Untuk memulai pengembangan dengan .NET, Anda perlu menginstal beberapa software dan tools berikut:

- **Visual Studio**: IDE ini merupakan pilihan yang sangat populer untuk pengembangan .NET. Anda bisa mengunduhnya dari situs resmi Microsoft.  Anda dapat mengunduh Visual Studio Community dari [tautan ini](https://visualstudio.microsoft.com/vs/community/).
- **Visual Studio Code**: IDE ini mendukung ekstensi .NET yang memungkinkan Anda untuk mengembangkan aplikasi .NET Core. Meskipun Visual Studio Code memiliki fitur yang lebih terbatas dibandingkan dengan Visual Studio, namun cukup populer karena kecepatan dan fleksibilitasnya.  Anda dapat mengunduh Visual Studio Code dari [tautan ini](https://code.visualstudio.com/download).
- **.NET SDK**: Anda perlu menginstal .NET SDK yang sesuai dengan kebutuhan proyek Anda. Anda bisa mengunduhnya dari situs resmi .NET. Anda dapat mengunduh .NET dari [tautan ini](https://dotnet.microsoft.com/en-us/download/dotnet/).


## 3. Membuat proyek awal .NET dengan Visual Studio

Berikut adalah langkah-langkah untuk membuat proyek Hello World dengan .NET:

1. Buka Visual Studio.
2. Pilih 'Create a new project'.
3. Pilih jenis proyek yang Anda inginkan, misalnya 'Console App' untuk aplikasi konsol.
4. Beri nama proyek Anda, misalnya 'HelloWorldApp'.
5. Klik Next dan pilih Framework .NET sesuai ketersediaan di perangkat anda.
6. Klik 'Create'.
7. Setelah proyek terbuka, Anda akan melihat file Program.cs. 
8. Ganti isi file Program.cs dengan kode berikut:

```csharp
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

8. Tekan tombol F5 atau pilih 'Start' di menu atas untuk menjalankan aplikasi.
9. Anda akan melihat output "Hello, World!" di console.


## 4. Membuat proyek awal .NET dengan Visual Studio Code

### Extension
Jika Anda menggunakan Visual Studio Code untuk mengembangkan aplikasi .NET, ada beberapa ekstensi yang sangat membantu untuk meningkatkan produktivitas dan pengalaman pengembangan Anda. Berikut adalah beberapa ekstensi yang berguna untuk pengembangan .NET di Visual Studio Code:

1. **C# for Visual Studio Code (powered by OmniSharp)**: 
   Ekstensi ini memberikan dukungan penuh untuk bahasa C# di Visual Studio Code. Ini memungkinkan fitur seperti IntelliSense, debugging, refactoring, dan banyak lagi.

2. **.NET Core Tools**: 
   Ekstensi ini memberikan antarmuka pengguna untuk sebagian besar perintah .NET CLI dan memudahkan Anda untuk menjalankan perintah .NET Core dari dalam Visual Studio Code.

3. **NuGet Package Manager**: 
   Dengan ekstensi ini, Anda dapat dengan mudah mencari, memasang, dan mengelola paket NuGet langsung dari Visual Studio Code.

4. **Code Runner**: 
   Meskipun bukan khusus untuk .NET, ekstensi ini memungkinkan Anda menjalankan kode C# atau bahasa pemrograman lainnya dari file yang sedang diedit.

5. **C# Extensions**: 
   Ekstensi ini memberikan beberapa fitur tambahan untuk pengembangan C# di Visual Studio Code, seperti snippet dan fitur lain yang berguna.

Pastikan untuk memeriksa detail setiap ekstensi, dan pastikan untuk menginstal versi yang kompatibel dengan versi Visual Studio Code yang Anda gunakan. Anda dapat menginstal ekstensi ini langsung dari menu ekstensi di Visual Studio Code.

### Template

Template berikut adalah jenis-jenis proyek yang dapat Anda buat saat menggunakan .NET untuk pengembangan aplikasi. Saat Anda membuat proyek baru di .NET, Anda dapat memilih salah satu dari template ini sesuai dengan jenis aplikasi yang ingin Anda buat. Setiap template memiliki konfigurasi default yang disesuaikan dengan jenis aplikasi yang spesifik.

Pemilihan template yang sesuai dapat mempermudah proses pengembangan karena template tersebut telah disiapkan dengan pengaturan default yang sesuai dengan jenis aplikasi yang Anda inginkan. Masing-masing template juga dilengkapi dengan struktur awal yang memudahkan Anda untuk mulai mengembangkan aplikasi tanpa perlu memulai dari awal.

| Template Name         | Short Name    | Language    | Tags                  |
|---------------------- | ------------  | ----------  | --------------------- |
| ASP.NET Core Web App  | webapp,razor  | [C#]        | Web/MVC/Razor Pages    |
| Blazor Server App     | blazorserver  | [C#]        | Web/Blazor            |
| Class Library         | classlib      | [C#],F#,VB  | Common/Library        |
| Console App           | console       | [C#],F#,VB  | Common/Console        |
| Windows Forms App     | winforms      | [C#],VB     | Common/WinForms       |
| WPF Application       | wpf           | [C#],VB     | Common/WPF            |

### Pembuatan Proyek
1. Buka Visual Studio Code.
2. Pilih Terminal > New Terminal
3. Buat nama folder proyek
4. Masuk ke dalam folder dan buat proyek dengan cara : dotnet new console
5. Ganti isi file Program.cs dengan kode berikut:

```csharp
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

6. Jalankan program dengan cara : dotnet run
7. Update program dapat dilakukan dengan cara : dotnet restore

Perintah `dotnet restore` adalah perintah yang digunakan untuk mengembalikan paket yang diperlukan oleh proyek .NET Anda. Saat Anda bekerja dengan proyek .NET, Anda sering kali menggunakan paket NuGet yang mengandung berbagai dependensi dan pustaka yang diperlukan oleh proyek Anda. Perintah `dotnet restore` secara khusus digunakan untuk mengunduh dan mengembalikan paket-paket tersebut ke dalam proyek Anda.

Berikut adalah beberapa kegunaan utama dari perintah `dotnet restore`:

1. **Mengembalikan Paket NuGet**: Ini membantu dalam mengunduh semua paket NuGet yang diperlukan oleh proyek Anda dan memastikan bahwa proyek Anda memiliki semua dependensi yang diperlukan untuk dikompilasi dan dijalankan.

2. **Memastikan Konsistensi Versi**: Perintah ini membantu memastikan bahwa semua paket yang diperlukan memiliki versi yang konsisten dengan yang ditentukan dalam file proyek atau file konfigurasi lainnya, sehingga memastikan bahwa aplikasi Anda memenuhi persyaratan dependensi yang benar.

3. **Mengelola Dependensi**: `dotnet restore` membantu Anda mengelola dependensi proyek dengan efisien. Ini memastikan bahwa proyek Anda dapat dikompilasi dan dijalankan tanpa masalah terkait dependensi yang hilang atau tidak terpenuhi.

Pada dasarnya, `dotnet restore` adalah langkah pertama yang perlu dilakukan setelah Anda menyalin proyek .NET ke lingkungan pengembangan baru. Ini memastikan bahwa semua dependensi yang diperlukan diunduh dan disiapkan sehingga proyek Anda siap untuk dikompilasi dan dijalankan.


Semoga tutorial ini membantu Anda untuk memulai dengan .NET

