with import <nixpkgs> {
    overlays = [
        (import ./dotnet-overlay.nix)
    ];
};
pkgs.mkShell {
  name = "projeto-fsharp";
  buildInputs = [
    dotnet-sdk_6
    docker
    docker-compose
  ];

  shellHook = ''
   dotnet tool restore
   dotnet paket restore
  '';
}
