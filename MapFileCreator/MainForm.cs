using System.Diagnostics;
using System.Security.Policy;

namespace MapFileCreator;

public partial class MainForm : Form
{
    private string _mapFileName;
    private MapLoader _mapLoader;
    private MapSaver _mapSaver;
    private List<MapItem> _mapItems;

    Form IndexForm = null;
    Form CreditInformationForm = null;
    Form InstallationHelpForm = null;

    public MainForm()
    {
        InitializeComponent();

        _mapLoader = new MapLoader();
        _mapSaver = new MapSaver();
        _mapItems = new List<MapItem>();
    }

    /// https://stackoverflow.com/questions/21835891/process-starturl-fails/61035650#61035650
    private void programHeaderLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(new ProcessStartInfo("https://github.com/ClassicUO/ClassicUO/wiki/World-Map") { UseShellExecute = true });
    }

    private void LoadMapButton_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Map Files|*.map";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _mapFileName = openFileDialog.FileName;
            _mapItems = _mapLoader.LoadMap(_mapFileName);
            UpdateMapItems(_mapItems);
        }
    }

    private void UpdateMapItems(List<MapItem> mapItems)
    {
        MapListView.BeginUpdate();
        MapListView.Items.Clear();
        foreach (var mapItem in mapItems)
        {
            var mapListViewItems = MapListView.Items.Add(mapItem.IsInCity ? "Yes" : "No");
            mapListViewItems.SubItems.Add(mapItem.Type);
            mapListViewItems.SubItems.Add(mapItem.X.ToString());
            mapListViewItems.SubItems.Add(mapItem.Y.ToString());
            mapListViewItems.SubItems.Add(mapItem.Facet.ToString());
            mapListViewItems.SubItems.Add(mapItem.Label);
        }
        MapListView.EndUpdate();
    }

    private void MapListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedIndex = -1;
        if (MapListView.SelectedIndices.Count > 0)
        {
            selectedIndex = MapListView.SelectedIndices[0];
        }

        if (selectedIndex == -1 || !_mapItems.Any() || selectedIndex > _mapItems.Count)
        {
            return;
        }

        var mapItem = _mapItems[selectedIndex];
        IsInCityCheckBox.Checked = mapItem.IsInCity;
        TypeTextBox.Text = mapItem.Type;
        CoordinateXUpDown.Value = mapItem.X;
        CoordinateYUpDown.Value = mapItem.Y;
        FacetUpDown.Value = mapItem.Facet;
        LabelTextBox.Text = mapItem.Label;
    }

    private void AddItemButton_Click(object sender, EventArgs e)
    {
        var mapItem = new MapItem
        {
            IsInCity = IsInCityCheckBox.Checked,
            Type = TypeTextBox.Text,
            X = (int)CoordinateXUpDown.Value,
            Y = (int)CoordinateYUpDown.Value,
            Facet = (int)FacetUpDown.Value,
            Label = LabelTextBox.Text
        };

        _mapItems.Add(mapItem);
        UpdateMapItems(_mapItems);
    }

    private void UpdateSelectedItemButton_Click(object sender, EventArgs e)
    {
        var selectedIndex = -1;
        if (MapListView.SelectedIndices.Count > 0)
        {
            selectedIndex = MapListView.SelectedIndices[0];
        }

        if (selectedIndex == -1 || !_mapItems.Any() || selectedIndex > _mapItems.Count)
        {
            return;
        }

        var mapItem = _mapItems[selectedIndex];
        mapItem.IsInCity = IsInCityCheckBox.Checked;
        mapItem.Type = TypeTextBox.Text;
        mapItem.X = (int)CoordinateXUpDown.Value;
        mapItem.Y = (int)CoordinateYUpDown.Value;
        mapItem.Facet = (int)FacetUpDown.Value;
        mapItem.Label = LabelTextBox.Text;

        UpdateMapItems(_mapItems);
    }

    private void DeleteSelectedItemButton_Click(object sender, EventArgs e)
    {
        var selectedIndex = -1;
        if (MapListView.SelectedIndices.Count > 0)
        {
            selectedIndex = MapListView.SelectedIndices[0];
        }

        if (selectedIndex == -1 || !_mapItems.Any() || selectedIndex > _mapItems.Count)
        {
            return;
        }

        _mapItems.RemoveAt(selectedIndex);
        UpdateMapItems(_mapItems);
    }

    private void MapIndexNumberHelpButton_Click(object sender, EventArgs e)
    {
        if (IndexForm == null)
        {
            IndexForm = new IndexForm();
            IndexForm.Closed += (x, y) => { IndexForm = null; };
            IndexForm.Show();
        }
    }

    private void SaveMapAsButton_Click(object sender, EventArgs e)
    {
        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Map files (.map)|*.map";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            _mapFileName = saveFileDialog.FileName;
            _mapSaver.SaveMap(_mapFileName, _mapItems);
        }
    }

    private void info_button_Click(object sender, EventArgs e)
    {
        if (CreditInformationForm == null)
        {
            CreditInformationForm = new CreditInformationForm();
            CreditInformationForm.Closed += (x, y) => { CreditInformationForm = null; };
            CreditInformationForm.Show();
        }
    }

    private void installationHelpButton_Click(object sender, EventArgs e)
    {
        if (InstallationHelpForm == null)
        {
            InstallationHelpForm = new InstallationHelpForm();
            InstallationHelpForm.Closed += (x, y) => { InstallationHelpForm = null; };
            InstallationHelpForm.Show();
        }
    }
}