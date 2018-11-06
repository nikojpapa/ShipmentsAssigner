FROM microsoft/dotnet:2.1-sdk

ENV DEBIAN_FRONTEND noninteractive

RUN apt-get update && apt-get install -y wget vim screen libnotify4 libgconf-2-4 libnss3 libgtk2.0-0 libxss1 libgconf-2-4 libasound2 libxtst6 libcanberra-gtk-dev libgl1-mesa-glx libgl1-mesa-dri libxkbfile1 libsecret-1-0 && rm -rf /var/lib/apt/lists/* && \
    wget https://go.microsoft.com/fwlink/?LinkID=760868 -O vscode.deb && \
    dpkg -i vscode.deb && \
    rm vscode.deb && \
    useradd -m vscode -s /bin/bash

USER vscode

RUN code --install-extension quantum.quantum-devkit-vscode

CMD cd /runbox_volumes/ShipmentsAssigner && dotnet add package nikojpapa.quantum.utils -s ./nuget-modules
