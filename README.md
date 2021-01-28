# Unity-WebCamTexture-WebGL-Sample
UnityのWebカメラ入力をWebGLビルドしたサンプルです。

# Demo
動作確認用ページは以下。<br>
https://kazuhito00.github.io/Unity-WebCamTexture-WebGL-Sample/

# Requirement 
* Unity 2020.1.6f1 or later

# Memo
WebGLビルドをGithub Pagesにホストする際には無圧縮でビルドする<br>
[Edit] -> [Project Setting...] -> [Player]<br>
<img src="https://user-images.githubusercontent.com/37477845/105736836-95ddfe00-5f78-11eb-920a-a6ac8dd1af0e.png" width="50%"><br>
[HTML5]タブ<br>
<img src="https://user-images.githubusercontent.com/37477845/105736851-99718500-5f78-11eb-9d50-03da9f5e0ccb.png" width="50%"><br>
[Publishing Settings] -> [Compression Format]<br>
[Disabled]に変更<br>
<img src="https://user-images.githubusercontent.com/37477845/105736874-a1312980-5f78-11eb-9a65-3e36703d1847.png" width="50%">

##### 映像が上下もしくは左右反転している場合
Plane>Transform>Scaleの値をマイナスにして反転させる。

##### 映像が暗い場合
ProjectウィンドウのAssetフォルダ内で右クリックしてCreate＞Materialを選択。<br>
作成したマテリアルを選択し、Inspectorビュー＞Shader＞Unlit/Textureに変更。<br>
Planeに適用する。

# Author
高橋かずひと(https://twitter.com/KzhtTkhs)
 
# License 
Unity-WebCamTexture-WebGL-Sample is under [Apache-2.0 License](LICENSE).
