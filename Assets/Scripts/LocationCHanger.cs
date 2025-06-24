using UnityEngine;

public class LocationChanger : MonoBehaviour
{
    public MeshRenderer targetSphereRenderer; // Seret inverted sphere ke sini di Unity Editor
    public Material[] locationMaterials;      // Seret semua material lokasi ke sini di Unity Editor

    // Fungsi yang dipanggil untuk mengubah lokasi
    // materialIndex adalah nomor urut material di array locationMaterials
    public void ChangeLocation(int materialIndex)
    {
        if (targetSphereRenderer != null && locationMaterials != null && materialIndex >= 0 && materialIndex < locationMaterials.Length)
        {
            // Mengganti material pada sphere dengan material lokasi yang baru
            targetSphereRenderer.material = locationMaterials[materialIndex];
        }
        else
        {
            Debug.LogError("Gagal mengubah lokasi. Periksa pengaturan di Inspector.");
        }
    }
}