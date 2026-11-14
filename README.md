# OculusEnableHighFPS

[![Build and Release](https://github.com/denpadokei/OculusEnableHighFPS/actions/workflows/build-and-release.yml/badge.svg)](https://github.com/denpadokei/OculusEnableHighFPS/actions/workflows/build-and-release.yml)

Oculus のリフレッシュレートを 120Hz に設定する MOD です。

## 機能

- `VRRenderingParamsSetup.OnEnable` に Postfix パッチを適用する
- `OVRPlugin.systemDisplayFrequency` を 120 に設定する
- 有効化時に Harmony パッチを適用し、無効化時に解除する

## 動作環境

| 項目 | 内容 |
| --- | --- |
| Beat Saber | 1.19.0 |
| 依存 MOD | BSIPA ^4.0.5 |
| 対象 | Oculus ランタイム (`Oculus.VR` の `OVRPlugin`) |

## インストール

1. Beat Saber を 1.19.0 に合わせる (BSManager などのバージョン管理ツールを推奨)
2. BSIPA と上記の依存 MOD をインストールする
3. [Releases](https://github.com/denpadokei/OculusEnableHighFPS/releases) から `OculusEnableHighFPS-0.0.2-bs1.19.0.zip` をダウンロードし、`Plugins` フォルダをゲームフォルダへ上書きコピーする

## 使い方

ゲーム内に UI や設定はありません。インストールすると、VR 描画の初期化後に 120Hz が要求されます。HMD と Oculus ランタイムが 120Hz に対応している必要があります。

## ビルド

```powershell
git clone https://github.com/denpadokei/OculusEnableHighFPS.git
cd OculusEnableHighFPS
dotnet build .\OculusEnableHighFPS\OculusEnableHighFPS.csproj -c Release
```

`BeatSaberDir` (または `GameDirectory`) に Beat Saber のインストール先を設定すると、ゲームの参照アセンブリを解決できます。

GitHub Actions の `build-and-release.yml` が push ごとにビルドし、`X.X.X` 形式のタグを push するとリリースを作成します。

## ライセンス

MIT ライセンスです。詳細は [LICENSE](LICENSE) を参照してください。
