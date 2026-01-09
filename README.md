# Energia API

Welcome! This README will help you get started with using the **Energia API** — a lightweight and easy-to-use library designed to interact with Roblox processes.

## 📦 Getting Started

To start using Energia in your project:

1. Download the `EnergiaAPI.dll`.
2. Add it as a reference in your C# project.
3. You're ready to go!

There's no complicated setup and updates are handled automatically behind the scenes. Just plug it in and begin building.

---

## 🧠 Summary & Quick Reference

Here’s what you can do with the Energia API:

| Method | Description |
|--------|-------------|
| `Attach(pid)` | Attaches to a specific Roblox process by PID. If none provided, attaches to all available instances. |
| `Kill(pid)` | Terminates a given Roblox instance. Without arguments, kills all attached ones. |
| `IsAttached(pid)` | Checks whether a process is currently attached. |
| `Execute(content, pid)` | Runs Lua code inside a Roblox instance. Optionally target a specific process. |
| `GetClients()` | Returns a list of currently running Roblox clients (`Client` objects). |
| `Refresh()` | Manually refreshes the internal state of attached processes. |

### Example Usage

```csharp
using System;
using EnergiaAPI;

class Program
{
    static void Main(string[] args)
    {
        // Automatically attach to any running Roblox instances
        Energia.Attach();

        // Listen for changes in attached instances
        Energia.InstancesChanged += (clients) =>
        {
            Console.WriteLine("Connected instances:");
            foreach (var client in clients)
            {
                Console.WriteLine($" - {client.Name} [{client.Id}]");
            }
        };

        // Execute some Lua script globally
        Energia.Execute("print('Hello from Energia!')");

        Console.ReadLine(); // Keep alive
    }
}
```
