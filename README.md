# WLED Video GUI

WLED Video GUI is a C# application that provides a graphical interface for streaming video from your desktop to a WLED controller. This application integrates a Python script (`wledvideo.py`) to handle the video streaming.

## Features

- Stream video from YouTube, local files, webcam, or desktop to a WLED controller.
- Configure video settings such as resolution, crop, scale, and gamma.
- Advanced settings for serial communication with the WLED controller.
- Live preview of the video being streamed.

## Screenshot
![WLED Video GUI](resources/screenshot.png)

## Requirements

- .NET Framework 4.7.2 or higher
- LibVLCSharp
- Python 3.x
- WLED controller

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/WLED-Video-GUI.git
    cd WLED-Video-GUI
    ```

2. Open the project in Visual Studio and restore the NuGet packages.

3. Install Python dependencies:
    ```sh
    pip install -r requirements.txt
    ```

4. Copy `wledvideo.py` to the appropriate directory.

## Configuration

1. Edit the `config.json` file to set your WLED controller's host, video resolution, and other settings.
2. Use the GUI to adjust settings and save configurations.

## Usage

1. Run the application from Visual Studio or the compiled executable.
2. Configure your video settings in the GUI.
3. Select your video source and click "Send to WLED".
4. Optionally, enable live preview to see the video being streamed.

## Development

### Code Structure

- `Form1.cs`: Main form and application logic.
- `Program.cs`: Entry point of the application.
- `wledvideo.py`: Python script for handling video streaming.

### Adding New Features

1. Fork the repository.
2. Create a new branch:
    ```sh
    git checkout -b feature-name
    ```
3. Make your changes.
4. Commit your changes:
    ```sh
    git commit -m "Description of feature"
    ```
5. Push to the branch:
    ```sh
    git push origin feature-name
    ```
6. Create a pull request.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
