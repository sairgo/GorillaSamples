# GorillaSamples

This repository contains a small set of C# projects that demonstrate how I structure .NET solutions using clean separation between UI, business logic, and domain models.

## Projects

Gorilla.WinFormsDemo  
A simple WinForms application that demonstrates:
- Use of DataGridView to display product lists.
- Separation between the UI layer and business logic through the ProductoService class.
- Synchronous and asynchronous data loading using async/await to keep the UI responsive.
- Integration with the Gorilla.BusinessLogic project to consume the FacturaService.
- Example of triggering business logic (invoice totals, tax calculation) directly from the form.

Gorilla.BusinessLogic  
Independent business logic project containing:
- Domain models: Factura and DetalleFactura.
- FacturaService for calculating totals and tax values.
- Clean, object-oriented structure designed to be easy to extend or reuse.
- Can be consumed by different frontends such as WinForms, web applications, APIs, or console applications.

## Architectural Approach

The two projects illustrate how I typically organize .NET applications:
- A clear separation of responsibilities across UI, services, and domain models.
- No business logic inside forms or UI elements.
- Modular and maintainable design suitable for long-term projects or enterprise systems.
