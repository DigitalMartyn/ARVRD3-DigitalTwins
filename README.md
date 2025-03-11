

# Unity Project Setup Guide

## Overview
This repository contains guides for creating interactive buttons using the XR Interaction Toolkit and developing a digital twin of the International Space Station (ISS) in Unity.

## Table of Contents
1. Creating Interactive Buttons
2. Creating a Digital Twin of the ISS

## Creating Interactive Buttons

### Best Practices for UI Design in XR
1. **Avoid 3D Text**: Use flat or slightly extruded text for better readability.
2. **Use Figma for UI Design**: Design UI elements in Figma and export them as PNGs.

### Setting Up the UI in Unity
1. **Import the Placeholder Image**:
   - Export the UI design from Figma as a PNG.
   - Import the PNG into Unity and set its texture type to Sprite (2D and UI).
2. **Create a Canvas**:
   - Create a new Canvas in Unity (`GameObject > UI > Canvas`).
   - Set the Canvas Render Mode to World Space.
   - Adjust the Canvas size and position to fit your scene.
3. **Add the Placeholder Image**:
   - Create an Image under the Canvas (`GameObject > UI > Image`).
   - Assign the imported PNG as the Source Image for the Image component.

### Adding Text and Buttons
1. **Add Text**:
   - Create a TextMeshPro text element under the Canvas (`GameObject > UI > Text - TextMeshPro`).
   - Adjust the text properties (font size, alignment, etc.) to match your design.
2. **Add Buttons**:
   - Create a Button under the Canvas (`GameObject > UI > Button - TextMeshPro`).
   - Customize the button's appearance and text.
   - Ensure the button has the necessary components for VR interaction, such as Tracked Device Graphic Raycaster.

### Adding Interactivity with Visual Scripting
1. **Set Up Visual Scripting**:
   - Add a Script Machine component to the Button.
   - Create a new Script Graph for the button.
2. **Debug Log on Button Click**:
   - Add an On Button Click node.
   - Connect it to a Debug Log node to print a message when the button is clicked.
3. **Play Audio on Button Click**:
   - Add an Audio Source component to the Button.
   - In the Script Graph, connect the On Button Click node to a Play One Shot node, and assign the Audio Source.
4. **Instantiate Objects on Button Click**:
   - Create a Prefab of the object you want to instantiate.
   - In the Script Graph, connect the On Button Click node to an Instantiate node, and assign the Prefab.

### Creating a Grabbable Menu
1. **Create a Grabbable Panel**:
   - Create a 3D object (e.g., a panel) and add a Canvas with UI elements (buttons, text) as children.
   - Add an XR Grab Interactable component to the panel.
   - Adjust the Rigidbody settings (disable gravity, set drag and angular drag) to ensure the panel behaves correctly when grabbed.

### Testing and Debugging
1. **Use the Device Simulator**:
   - Test the UI and interactions using the XR Device Simulator in Unity.
   - Ensure all buttons and interactions work as expected.
2. **Deploy to VR Headset**:
   - Build and run the project on a VR headset to test the UI in an immersive environment.

### Additional Enhancements
1. **Customize UI Elements**:
   - Further customize the appearance and behavior of UI elements to match your design vision.
2. **Explore Advanced Features**:
   - Experiment with more advanced features of the XR Interaction Toolkit, such as climb interactables and hand menus.

## Creating a Digital Twin of the ISS

### Setup and Import Resources
1. **Download and Import Unity Package**:
   - Ensure you have the readJson Unity package.
   - Import the package into your Unity project by dragging it into the Assets folder.

### Initial Scene Setup
1. **Open the Scene**:
   - Locate and open the readJson scene provided in the package.
2. **Telemetry Panel**:
   - Find the TelemetryPanel prefab in the scene. This prefab includes a script to read and display JSON data.

### Understanding JSON Data
1. **JSON Basics**:
   - Familiarize yourself with the JSON structure used in the project.
   - Example:
     ```json
     {
       "solarPanels": [
         {
           "panelID": "airlock001",
           "temperature": 25.6,
           "status": true
         },
         ...
       ]
     }
     ```
2. **Script Overview**:
   - The script reads JSON data and updates the TelemetryPanel. You can view and modify the script in your code editor (e.g., VS Code).

### Customizing the Telemetry Panel
1. **Prefab Modifications**:
   - Duplicate the TelemetryPanel prefab to create multiple panels.
   - Adjust the arrayNumber property in the inspector to display different data entries.

### Creating the VR Experience
1. **Switch to the Demo Scene**:
   - Switch over to the Demo Scene asset in the project.
2. **Switch off Unused Environment Assets**:
   - Switch off the environment assets you don’t plan to use.

### Integrating the ISS Model
1. **Import ISS Model**:
   - Download the ISS model in FBX format and import it into Unity.
   - Drag the ISS model into your scene and position it appropriately.
2. **Lighting and Environment**:
   - Set up a directional light to simulate sunlight.
   - Increase the intensity and change the color to white.
   - Use a skybox from the Sky Series Freebie package to create a space environment.
3. **Positioning and Scaling**:
   - Position the ISS model and TelemetryPanel prefabs within the VR environment.
   - Adjust the scale of the models and panels to fit the VR space.

### Testing and Debugging
1. **Play Mode**:
   - Enter Play Mode to test the setup.
   - Ensure the TelemetryPanel displays the correct data.

### Final Adjustments
1. **Fine-Tuning**:
   - Make any necessary adjustments to the positioning, scaling, and appearance of the models and panels.
   - Test the VR experience thoroughly to ensure a smooth and immersive experience.

### Additional Enhancements
1. **Custom Data**:
   - If desired, create your own JSON data to display different information.
2. **Visual Improvements**:
   - Enhance the visual appeal by adding more details to the environment and models.
