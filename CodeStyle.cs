using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Scripts.CustomEdit.AssetsTargeting.Code_Style
{
    public abstract class CodeStyle : MonoBehaviour
    {
        #region Fields

        [SerializeField] private CodeStyle _style;
        
        private const int MAX_LENGTH = 100; 
        protected const int MIN_LENGTH = 1;
        internal const string CODE_STYLE_NAME = "CodeStyle"; 
        public const string CODE_STYLE_PREFIX = "CodeStyle";
        
        static private int _number;
        static protected CodeStyle _instance;
        static internal CodeStyle Instance;
        static public CodeStyle Instance2;
        
        private readonly int _length2;
        protected readonly CodeStyle _codeStyle1;
        internal readonly CodeStyle CodeStyle22;
        public readonly CodeStyle CodeStyle33;
        
        private int _length;
        protected CodeStyle _codeStyle;
        internal CodeStyle CodeStyle2;
        public CodeStyle CodeStyle3;

        #endregion

        #region Properties

        [field: SerializeField] public CodeStyle CodeStyle222 { get; private set; }
        
        public CodeStyle CodeStyle4 {get; set;}
        public CodeStyle CodeStyle6 {get; private set;}
        public CodeStyle CodeStyle5 {get; protected set;}

        #endregion

        protected CodeStyle() {
            
        }

        #region Methods. By abstraction Level

        static private void InitializeCodeStyle8() {}

        protected abstract void Initialize();
        internal abstract void InitializeCodeStyle();
        public abstract void SetCodeStyle();

        protected virtual void InitializeCodeStyle2() {}
        internal virtual void SetCodeStyle2() {}
        public virtual void InitializeCodeStyle3() {}

        public void InitializeCodeStyle4() {}
        internal void InitializeCodeStyle6() {}
        protected void InitializeCodeStyle5() {}
        private void InitializeCodeStyle7() {}

        #endregion

        #region MonoBehavior

        /// <summary>
        /// Constructor for MonoBehavior
        /// </summary>
        [Inject]
        public void Construct(CodeStyle codeStyle) {
            CodeStyle6 = codeStyle;
        }

        /// <summary>
        /// MonoBehavior LifeCycle
        /// </summary>
        private void OnEnable() => throw new NotImplementedException();
        private void OnDisable() => throw new NotImplementedException();

        private void Awake() => throw new NotImplementedException();

        private void Start() => throw new NotImplementedException();

        private void Update() => throw new NotImplementedException();

        private void FixedUpdate() => throw new NotImplementedException();

        private void LateUpdate() => throw new NotImplementedException();
        
        private void OnValidate() => throw new NotImplementedException();

        #endregion

        #region Naming / Formatting

        private async void DoSomethingAsync() {
            var task = DoSomeAsync();
            await task;
        }

        private async UniTask DoSomeAsync() {
            await UniTask.Yield();
        }
        
        private int GetNumberRecursive() {
            try {
                return GetNumberRecursive();
            }
            catch (StackOverflowException e) {
                throw e;
            }
        }

        private void GenericMethod<TComponent, TCodeStyle>(TComponent obj, TCodeStyle codeStyle) 
            where TComponent : Component
            where TCodeStyle : CodeStyle 
        {
            
        }

        #endregion
    }
}