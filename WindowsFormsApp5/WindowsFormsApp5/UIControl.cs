using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    //界面控制类
    public class UIControl
    {
        //单例模式
        private static UIControl uc = new UIControl();
        public static UIControl inst
        {
            get
            {
                return uc;
            }
        }

        public UIControl()
        {
            uiArr = new UIType[10];
            uiArr[uiIndex++] = UIType.Main;
        }

        UserControl currentUI; //表示当前打开的界面
        UIType[] uiArr;//窗口层级数组
        int uiIndex = 0;
        private Main main; //主界面容器
        //设置主界面的容器
        public void setMain(Main main)
        {
            this.main = main;
        }
        public void ShowUI(UIType type)
        {
            if (currentUI != null)
            {
                main.container.Controls.Remove(currentUI);
            }
            //if (uiArr[uiIndex-1] != type)
           // {
                UserControl uc = GetUIByType(type);//根据类型返回窗口实例
                if (uc == null)//返回主菜单，相当于做一个重置功能
                {
                    main.ShowMainMenu(true);
                    currentUI = null;
                    uiArr = new UIType[10];
                    uiArr[0] = UIType.Main;
                    uiIndex = 1;
                }
                else
                {
                    main.container.Controls.Add(uc);
                    currentUI = uc;
                    currentUI.Dock = DockStyle.Fill;
                    RefreshUserUI(currentUI);
                    uiArr[uiIndex++] =type;
                    main.ShowMainMenu(false);
                }
                
           // }
        }

        private void RefreshUserUI(UserControl currentUI)
        {
            if(currentUI is UISongChoose)
            {
                ((UISongChoose)currentUI).RefreshData();
            }else if(currentUI is UIAreaChoose)
            {
                ((UIAreaChoose)currentUI).RefreshData();
            }
            else if (currentUI is UISingerChoose)
            {
                ((UISingerChoose)currentUI).RefreshData();
            }
            else if (currentUI is UISexChoose)
            {
                ((UISexChoose)currentUI).RefreshData();
            }else if (currentUI is UIPinyinChoose)
            {
                ((UIPinyinChoose)currentUI).RefreshData();
            }else if (currentUI is UITypeChoose)
            {
                ((UITypeChoose)currentUI).RefreshData();
            }
        }

        private UISexChoose uISexChoose;
        private UIAreaChoose uIAreaChoose;
        private UISingerChoose uISingerChoose;
        private UISongChoose uISongChoose;
        private UIPinyinChoose uiPinyinChoose;
        private UITypeChoose uITypeChoose;
        public UserControl GetUIByType(UIType type)
        {
            switch (type)
            {
                case UIType.Main:return null;
                case UIType.SexChoose:return uISexChoose==null? uISexChoose=new UISexChoose(): uISexChoose;
                case UIType.AreaChoose:return uIAreaChoose==null? uIAreaChoose=new UIAreaChoose(): uIAreaChoose;
                case UIType.SingerChoose:return uISingerChoose==null? uISingerChoose=new UISingerChoose(): uISingerChoose;
                case UIType.SongChoose:return uISongChoose==null? uISongChoose=new UISongChoose(): uISongChoose;
                case UIType.Pinyin:return uiPinyinChoose == null ? uiPinyinChoose = new UIPinyinChoose() : uiPinyinChoose;
                case UIType.SongType:return uITypeChoose == null ? uITypeChoose = new UITypeChoose() : uITypeChoose;
            }
            return null;
        }
        //返回主菜单
        internal void ReturnMain()
        {
            if (currentUI != null)
            {
                main.container.Controls.Remove(currentUI);
            }
            uiArr = new UIType[10];
            uiArr[0] = UIType.Main;
            uiIndex = 1;
            main.ShowMainMenu(true);
            currentUI = null;
        }
        //返回上级菜单 
        internal void ReturnUp()
        {
            //先把当前的给移掉
            if (currentUI != null)
            {
                main.container.Controls.Remove(currentUI);
            }
            //添加数组的上一个索引的界面
            uiIndex -= 2;
            ShowUI(uiArr[uiIndex]);
        }
    }

    public enum UIType
    {
        Main,SexChoose,AreaChoose,SingerChoose,
        SongChoose, Pinyin,SongType, SongTypeChoose,
    }
}
