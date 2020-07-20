/**
 * 回答方式が変更されたときの挙動
 */
const selectedItem = document.getElementById('question-type');
selectedItem.addEventListener('change', (e) => {
  const choiceList = document.getElementById('choice-list');
  switch (e.srcElement.value) {
    case "1":
    case "2":
      choiceList.classList.remove('hidden-item');
      break;
    default:
      choiceList.classList.add('hidden-item');
      break;
  }
});

/**
 * DOM読み込み完了時の処理
 */
document.addEventListener('DOMContentLoaded', function () {
  const choiceList = document.getElementById('choice-list');
  choiceList.classList.add('hidden-item');
});
