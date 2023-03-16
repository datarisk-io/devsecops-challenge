self: super:
let
  pname = "dotnet-sdk";
  platform = if super.pkgs.stdenv.isLinux then "linux" else "osx";
  suffix = "x64";
  shaLinux = "2c5fb1j8yb64sh28jabghv5mjhqhi5171zyy2kkmcpfkfqkv4ikvr6sa9w127gdl89mrsawnznf61daq8nxawgl78pfkna5silc7sc1";
  shaOsx = "/33yDOkFTtUNUh66iOBjQi76TUjLMRfPczzG7OokASwqw09t8Q2I9k/nqVK7lkVaPC64d/HVDAt7yu3xH5jOgg==";
in
{
  dotnet-sdk_6 = super.dotnetCorePackages.sdk_6_0.overrideAttrs (attrs: rec {
    version = "6.0.202";
    
    src = super.fetchurl {
      url = "https://dotnetcli.azureedge.net/dotnet/Sdk/${version}/${pname}-${version}-${platform}-${suffix}.tar.gz";
      sha512 = if super.pkgs.stdenv.isLinux then shaLinux else shaOsx;
    };
  });
}
