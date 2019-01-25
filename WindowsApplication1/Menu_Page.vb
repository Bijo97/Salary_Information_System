Public Class Menu_Page

    Private Sub TambahDataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataKaryawanToolStripMenuItem.Click
        Tambah_Data_Karyawan.show()
        Me.Close()
    End Sub

    Private Sub EditDataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDataKaryawanToolStripMenuItem.Click
        Edit_Data_Karyawan.Show()
        Me.Close()
    End Sub

    Private Sub TambahDataDepartemenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataDepartemenToolStripMenuItem.Click
        Tambah_Data_Departemen.Show()
        Me.Close()
    End Sub

    Private Sub EditDataDepartemenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDataDepartemenToolStripMenuItem.Click
        Edit_Data_Departemen.Show()
        Me.Close()
    End Sub

    Private Sub HapusDataDepartemenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusDataDepartemenToolStripMenuItem.Click
        Hapus_Data_Departemen.Show()
        Me.Close()
    End Sub

    Private Sub LihatLaporanGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatLaporanGajiToolStripMenuItem.Click
        Rincian_Gaji.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Absensi.show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub MasterGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterGajiToolStripMenuItem.Click
        Master_Gaji.Show()
        Me.Close()
    End Sub

    Private Sub CutiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutiToolStripMenuItem.Click
        Add_Cuti.Show()
        Me.Close()
    End Sub
End Class