# NoteMaster 项目文档

## 一、项目概述

NoteMaster 是一款功能丰富的笔记管理应用程序，支持笔记的创建、编辑、删除，待办事项管理，文件夹管理等功能。用户可以方便地组织和管理自己的笔记，提高工作和学习效率。

## 二、项目组成

```txt
NoteMaster
├── App.xaml
├── App.xaml.cs
├── AssemblyInfo.cs
├── Models
│   ├── Note.cs
│   ├── Folder.cs
│   └── TodoItem.cs
├── NoteMaster.csproj
├── NoteMaster.sln
├── Services
│   └── DataStorageService.cs
├── Utils
│   └── BooleanToVisibilityConverter.cs
├── ViewModels
│   ├── MainViewModel.cs
│   ├── HomePageViewModel.cs
│   ├── NoteEditPageViewModel.cs
│   ├── ArchiveViewModel.cs
│   ├── TodoPageViewModel.cs
│   └── NotesPageViewModel.cs
└── Views
    ├── Pages
    │   ├── HomePage.xaml
    │   ├── HomePage.xaml.cs
    │   ├── NoteEditPage.xaml
    │   ├── NoteEditPage.xaml.cs
    │   ├── NotesPage.xaml
    │   ├── NotesPage.xaml.cs
    │   ├── TodoPage.xaml
    │   ├── TodoPage.xaml.cs
    │   └── PaymentPage.xaml
    ├── MainWindow.xaml
    ├── MainWindow.xaml.cs
    ├── RenameFolderDialog.xaml.cs
    ├── Themes
    │   └── LightTheme.xaml
    ├── Assets
    │   └── Icons
    │       └── Icons.xaml
    └── Styles
        ├── MainStyle.xaml
        ├── HomePageStyle.xaml
        ├── NoteEditPageStyle.xaml
        └── NotesPageStyle.xaml
```

### 1. 视图层（Views）

- **主窗口（MainWindow）**：应用程序的主界面，包含菜单栏和页面导航框架。
- 页面（Pages）：
	- **HomePage**：笔记首页，展示笔记列表，支持笔记的搜索和筛选。
	- **NoteEditPage**：笔记编辑页面，用于创建和编辑笔记。
	- **NotesPage**：归档板块，展示文件夹和笔记列表，支持文件夹的创建、删除、重命名等操作。
	- **TodoPage**：待办事项页面，用于管理待办事项。
	- **PaymentPage**：支付页面（目前功能未详细实现）。
- 对话框（Dialogs）：
	- **SelectFolderDialog**：选择文件夹对话框。
	- **RenameFolderDialog**：重命名文件夹对话框。
- 编辑窗口（EditWindow）：
	- **NoteEditWindow**：笔记编辑窗口。

### 2. 视图模型层（ViewModels）

- **MainViewModel**：主窗口的视图模型。
- **HomePageViewModel**：首页的视图模型。
- **NoteEditPageViewModel**：笔记编辑页面的视图模型，负责处理笔记的创建、编辑和删除功能。
- **ArchiveViewModel**：归档板块的视图模型。
- **TodoPageViewModel**：待办事项页面的视图模型。

### 3. 模型层（Models）

- **Note**：笔记模型，包含笔记的标题、内容、更新时间等信息。
- **Folder**：文件夹模型，包含文件夹的名称、更新时间等信息。
- **TodoItem**：待办事项模型。

### 4. 服务层（Services）

- **DataStorageService**：数据存储服务，负责笔记、文件夹、待办事项等数据的存储和读取。

### 5. 工具类（Utils）

- **FolderNameConverter**：文件夹名称转换器，用于将文件夹 ID 转换为文件夹名称。
- **BooleanToVisibilityConverter**：布尔值到可见性转换器，用于根据布尔值控制元素的可见性。
- **InverseBooleanConverter**：布尔值反转转换器。

### 6. 资源文件（Resources）

- **Themes**：主题文件，定义了应用程序的颜色和样式。
- **Assets**：图标和头像等资源文件。
- **Styles**：样式文件，定义了应用程序中各种控件的样式。

## 三、技术栈

- ### 1. 编程语言

	- **C#**：作为主要的编程语言，用于编写应用程序的逻辑代码，利用其面向对象的特性和丰富的类库实现各种功能。

	### 2. 框架

	- **WPF（Windows Presentation Foundation）**：用于创建桌面应用程序的用户界面，提供了丰富的控件和布局方式，支持数据绑定、样式模板等特性，使界面开发更加高效和灵活。

	### 3. 数据处理

	- **Newtonsoft.Json**：用于 JSON 数据的序列化和反序列化，方便将对象数据转换为 JSON 字符串进行存储，以及将 JSON 字符串转换为对象数据进行读取。
	- **SQLite**：轻量级的嵌入式数据库，用于数据的持久化存储，支持事务处理和 SQL 查询，适合小型应用程序的数据存储需求。

	### 4. 设计模式

	- **MVVM（Model - View - ViewModel）**：实现视图和逻辑的分离，提高代码的可维护性和可测试性。视图（View）负责界面的展示，视图模型（ViewModel）负责处理业务逻辑和数据绑定，模型（Model）负责数据的存储和管理。

	### 5. 其他技术

	- **XAML（Extensible Application Markup Language）**：用于定义 WPF 应用程序的界面布局和样式，通过声明式的方式创建用户界面，使代码结构更加清晰。
	- **RelayCommand**：自定义的命令类，实现 `ICommand` 接口，用于处理界面上的命令操作，如按钮点击事件等。

## 四、环境要求

- **操作系统**：Windows
- **.NET 版本**：与项目兼容的 .NET 框架版本

## 五、安装与运行

### 1. 克隆项目

```bash
git clone <项目仓库地址>
```

### 2. 打开项目

使用 Visual Studio 或其他支持 C# 和 WPF 的开发工具打开项目文件。

### 3. 还原 NuGet 包

确保项目所需的 NuGet 包已正确还原。

### 4. 运行项目

在开发工具中点击运行按钮，启动应用程序。

## 六、功能特性

### 1. 笔记管理

- **创建笔记**：在首页或归档板块中点击相应按钮，进入笔记编辑页面创建新笔记。
- **编辑笔记**：双击笔记卡片或在笔记列表中选择笔记，进入笔记编辑页面进行编辑。
- **删除笔记**：在笔记编辑页面或归档板块中执行删除操作。

### 2. 文件夹管理

- **创建文件夹**：在归档板块中点击 “新建文件夹” 按钮创建新文件夹。
- **删除文件夹**：选择文件夹后点击 “删除文件夹” 按钮删除文件夹。
- **重命名文件夹**：选择文件夹后点击 “重命名文件夹” 按钮，在弹出的对话框中输入新名称。

### 3. 待办事项管理

- **添加待办事项**：在待办事项页面的输入框中输入待办事项内容，按回车键添加。
- **设置提醒**：为待办事项设置提醒时间。

### 4. 搜索与筛选

- **搜索笔记**：在首页的搜索框中输入关键词，搜索相关笔记。
- **筛选笔记**：通过标签/标题/正文等条件筛选笔记。

## 七、代码结构说明

### 1. 命名空间

- **NoteMaster.Views**：包含所有视图相关的类和 XAML 文件。
- **NoteMaster.ViewModels**：包含所有视图模型相关的类。
- **NoteMaster.Models**：包含所有模型相关的类。
- **NoteMaster.Services**：包含所有服务相关的类。
- **NoteMaster.Utils**：包含所有工具类。

### 2. 文件命名规范

- **XAML 文件**：以 `.xaml` 结尾，用于定义视图的布局和样式。
- **C# 文件**：以 `.xaml.cs` 结尾，用于处理视图的逻辑。
- **ViewModel 文件**：以 `ViewModel.cs` 结尾，实现视图模型的功能。
- **Model 文件**：以 `.cs` 结尾，定义模型的属性和方法。