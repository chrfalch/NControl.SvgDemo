# NControl.SvgDemo
This repository contains a quick demo that shows how Svg files created with Sketch can be used with NControl in Xamarin.Forms.

The key to success is to set the correct SvgAssemblyType and SvgResource, while setting up the layout options to the correct settings. 

```csharp
new SvgImage{
    // Provide a type contained in the assembly where your svg file
    // is located, I often create a c# class in the same directory
    // as the resources itself to use this to resolve types.
    SvgAssemblyType = typeof(ResourceLoader),

    // Now lets find the name of the resource by using the namespace from
    // the class ResourceLoader (it needs to contain the name of the folder
    // where the class and resource is located
    SvgResource = typeof(ResourceLoader).Namespace + ".Smile.svg",

    // Set height request and layout info to calculate layout
    HeightRequest = 55,
    HorizontalOptions = LayoutOptions.Center,
  }
```
