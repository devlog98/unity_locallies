﻿using Locallies.Core;
using UnityEngine.UI;

/*
 * Localizes element of type Text
 * Put this script into a Text object to use it
*/

namespace Locallies.Tools {
    public class LocalizeText : LocalizeObject {
        // reference of Text object
        private Text element;

        // initial localization
        private void Start() {
            element = GetComponent<Text>();
            Localize();
        }

        // updates in game text
        public override void Localize() {
            element.text = LocalizationManager.instance.Localize(key);
        }
    }
}