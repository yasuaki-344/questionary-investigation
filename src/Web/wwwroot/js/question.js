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
 * 選択肢追加ボタンの機能実装
 */
const btnAddChoice = document.getElementById('btn-add-choice');
btnAddChoice.addEventListener('click', () => {
  const choiceItems = document.getElementById('choice-items');
  const addElements = document.getElementById('choice-element-base').children;
  const addItem = document.createElement('li');

  const index = choiceItems.childElementCount;
  for (let i = 0; i < addElements.length; i++) {
    const element = addElements[i].cloneNode(true);
    element.name = 'QuestionChoices[' + index + '].QuestionString';
    addItem.appendChild(element);
  }
  choiceItems.insertAdjacentElement('beforeend', addItem);
});

/**
 * 選択肢削除ボタンの機能実装
 */
const btnRemoveChoice = document.getElementById('btn-remove-choice');
btnRemoveChoice.addEventListener('click', () => {
  const choiceItems = document.getElementById('choice-items');
  choiceItems.lastChild.remove();
});

/**
 * DOM読み込み完了時の処理
 */
document.addEventListener('DOMContentLoaded', function () {
  const choiceList = document.getElementById('choice-list');
  choiceList.classList.add('hidden-item');
});
