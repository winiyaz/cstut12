# cstut1
1. Work for the CSCrashCourse goes in here
2. This will have the notes

# Notes section 
1. MVC - Model View Controller Architecture of the Csharp Applications 
2. `.sln` - Collection of several projects
3. `.cs` - Csharp File  
4. `NameSpaces` - Set of classes seperated by name
	1. Classes similar to python 
	1. Done to avoid collision - So same naem classes in different namespaces 

# Github Actions 
- This is the yml which you will add at the end for running gh actions for building executables for windows and linux 

```yml 
# Source

# Actual yaml this has to be in the worflows with name- dotflow.yml
name: CI/CD Pipeline for .NET Console App

on:
  push:
    branches:
      - master

permissions:
  contents: write  # Required for creating releases

jobs:
  build:
    runs-on: ${{ matrix.os }}
    strategy:
      matrix:
        os: [windows-latest, ubuntu-latest]  # Add more OSes if needed (e.g., macos-latest)
        include:
          - os: windows-latest
            runtime: win-x64
          - os: ubuntu-latest
            runtime: linux-x64
    steps:
    - name: Checkout code
      uses: actions/checkout@v4

    - name: Setup .NET
      uses: actions/setup-dotnet@v4
      with:
        dotnet-version: '8.x'

    - name: Cache .NET dependencies
      uses: actions/cache@v3
      with:
        path: ~/.nuget/packages
        key: ${{ runner.os }}-nuget-${{ hashFiles('**/packages.lock.json') }}
        restore-keys: |
          ${{ runner.os }}-nuget-

    - name: Restore dependencies
      run: dotnet restore

    - name: Build
      run: dotnet build --configuration Release --no-restore

    - name: Test
      run: dotnet test --no-build --verbosity normal --logger "trx;LogFileName=TestResults/test-results.trx"

    - name: Publish Test Results
      uses: actions/upload-artifact@v4
      with:
        name: test-results-${{ matrix.os }}
        path: TestResults/
      if: always()

    - name: Publish Standalone Executable
      run: dotnet publish --configuration Release -r ${{ matrix.runtime }} --self-contained -o ./publish

    - name: Compress Artifacts (Windows)
      if: matrix.os == 'windows-latest'
      run: Compress-Archive -Path .\publish\* -DestinationPath cstut1PANTY-windows.zip

    - name: Compress Artifacts (Linux)
      if: matrix.os == 'ubuntu-latest'
      run: |
        mkdir -p cstut1PANTY-linux
        cp -r ./publish/* cstut1PANTY-linux/
        tar -czvf cstut1PANTY-linux.tar.gz cstut1PANTY-linux

    - name: Clean Up (Optional)
      shell: pwsh  # Use PowerShell Core
      run: |
        if ("${{ matrix.os }}" -eq "windows-latest") {
          Remove-Item -Recurse -Force ./publish
        } else {
          rm -rf ./publish
        }

    - name: Upload Artifact
      uses: actions/upload-artifact@v4
      with:
        name: cstut1PANTY-${{ matrix.os }}
        path: |
          cstut1PANTY-windows.zip
          cstut1PANTY-linux.tar.gz

  release:
    needs: build
    runs-on: ubuntu-latest

    steps:
    - name: Checkout code
      uses: actions/checkout@v4

    - name: Download Artifacts
      uses: actions/download-artifact@v4
      with:
        path: ./artifacts

    - name: Create Release
      uses: softprops/action-gh-release@v1
      with:
        tag_name: cstut1PANTY-v${{ github.run_number }}
        name: cstut1PANTY Release v${{ github.run_number }}
        draft: false
        prerelease: false
        files: |
          ./artifacts/cstut1PANTY-windows-latest/cstut1PANTY-windows.zip
          ./artifacts/cstut1PANTY-ubuntu-latest/cstut1PANTY-linux.tar.gz
      env:
        GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
```
- Tested and working