Unity 2D スネークゲーム

【概要】
- これは Unity 6 を使用して制作された 2D スネーク風ゲームです。
- ゲーム開始時に男性または女性キャラクターを選択でき、キャラクターが肉を食べることで体が伸び、スピードもアップしていきます。
- ゲーム終了後にはスコアと肉の取得数がアニメーション付きで表示されます。

【特徴】
- 男性／女性キャラクターの選択が可能。選択したキャラクターに応じたアニメーション。
- 肉を食べると体が成長し、蛇のように追従して移動。
- 陸地／水上によって異なる死亡エフェクト。
- 食べるごとにスピードが上昇（最大速度あり）。
- ゲームオーバー画面にスコアと取得肉数のカウントアニメーション。
- ESCキーでいつでもゲーム終了可能。
- 4Kディスプレイを含む、様々な解像度に対応したUI自動スケーリング。

【操作方法】
- 矢印キー：移動
- ESCキー：ゲームを終了
- UI画面：マウスでクリックする

【プロジェクト構成】
- Assets/
  - Scenes：TitleScene（タイトル画面）、GameScene（ゲーム本編）、EndScene（ゲーム終了画面）
  - Scripts：キャラクター制御、追従システム、マネージャー、UI制御など
  - Prefabs：キャラクター、体、肉、エフェクトなどのプレハブ
  - Animations：Animator Controller とアニメーションファイル

【使用技術・プラグイン】
- Unity 6000.0.23f1
- TextMeshPro（テキストUI）

補足：
- 数字アニメーションは Coroutine を使用してスムーズにカウントアップします。
- Canvas Scaler は "Scale With Screen Size" に設定、基準解像度は 1920x1080、Match は 0.5 に設定。
- TextMeshPro は Auto Size 設定を使い、どの解像度でもテキストが見やすく表示されます。
