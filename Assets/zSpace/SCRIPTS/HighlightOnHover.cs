////////////////////////////////////////////////////////////////////////////////
//
//  Copyright (C) 2007-2020 zSpace, Inc.  All Rights Reserved.
//
////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace zSpace.Core.Samples
{
    public class HighlightOnHover : MonoBehaviour,
        IPointerEnterHandler, IPointerExitHandler
    {
        ////////////////////////////////////////////////////////////////////////
        // Inspector Fields
        ////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// The color to set an object's material to when hovered.
        /// </summary>
        [Tooltip("The color to set an object's material to when hovered.")]
        public Color HighlightColor;

        ////////////////////////////////////////////////////////////////////////
        // MonoBehaviour Callbacks
        ////////////////////////////////////////////////////////////////////////

        void Start() 
        {
            this._child = this.gameObject.transform.GetChild(0).gameObject;
            this._mat = this.gameObject.GetComponent<MeshRenderer>().material;
            this._oldColor = this._mat.GetColor("_Color");
        }

        ////////////////////////////////////////////////////////////////////////
        // Public Methods
        ////////////////////////////////////////////////////////////////////////

        public void OnPointerEnter(PointerEventData evtData)
        {
            this._child.SetActive(true);
            this._mat.SetColor("_Color", HighlightColor);
            this.txt.SetActive(true);
        }

        public void OnPointerExit(PointerEventData evtData)
        {
            this._child.SetActive(false);
            this._mat.SetColor("_Color", _oldColor);
            this.txt.SetActive(false);
        }

        ////////////////////////////////////////////////////////////////////////
        // Private Members
        ////////////////////////////////////////////////////////////////////////

        private Color _oldColor;
        private Material _mat;
        private GameObject _child;
        public GameObject txt;
    }
}
