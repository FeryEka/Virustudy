using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoalSetting : MonoBehaviour
{

    public GameObject Feedback, benar, salah, imgPenilaian, imgHasil;
    public TextAsset bankSoal; //Get text soal dinamis
    private string[] soal;
    private string[,] soalBag; //aray 2 dimensi untuk memisahkan soal dan jawaban pada array
    
    int indexSoal;
    int maxSoal;
    int urutanSoal;
    bool ambilSoal;
    char kunciJawaban;

    bool[] soalSelesai;

    public Text Pertanyaan, A, B, C, D, hasilNilai, hasilNilaiHuruf, jawabBnr, jawabSlh;

    bool isHasil;
    private float durasi;
    public float durasiPenilaian;

    int jwbBenar, jwbSalah;

    float nilai;

    // Start is called before the first frame update
    void Start()
    {
        durasi = durasiPenilaian;

        soal = bankSoal.ToString().Split('#'); //Get index array dari bankSoal. tapi panjang array dipisahkan oleh tanda pagar '#'

        soalSelesai = new bool[soal.Length];

        soalBag = new string[soal.Length, 6]; //panjang array di deklarasikan menjadi index menjadi 6
        maxSoal = soal.Length;
        
        olahSoal();

        ambilSoal = true;
        TampilkanSoal();

    }

    private void olahSoal()
    {
        //memisahkan soal dan jawaban pada array
        for (int i = 0; i < soal.Length; i++)
        {
            //menyimpan sementara index ke tempSoal 
            string[] tempSoal = soal[i].Split('+'); //yang di simpan harusnya yang bertanda # jadi yang bertanda + dipisahkan
            for (int j = 0; j < tempSoal.Length; j++)
            {
                soalBag[i, j] = tempSoal[j]; //kondisi perulangan yang hanya bertanda '#' (# = pertanyaan) (+ = jawaban) (+ pada index[5] = kuncijawban)
                continue;
            }
            continue;
        }
    }

    private void TampilkanSoal()
    {
        urutanSoal = 1;
        if (indexSoal < maxSoal)
        {
            if (ambilSoal)
            {
                for(int i = 0; i < soal.Length; i++)
                {
                    int randomIndexSoal = Random.Range(0, soal.Length);
                    print("random" + randomIndexSoal);
                    if (!soalSelesai[randomIndexSoal])
                    {
                        //menampilkan pertanyaan
                        Pertanyaan.text = soalBag[randomIndexSoal, 0];
                        //menampilkan jawaban
                        A.text = soalBag[randomIndexSoal, 1];
                        B.text = soalBag[randomIndexSoal, 2];
                        C.text = soalBag[randomIndexSoal, 3];
                        D.text = soalBag[randomIndexSoal, 4];
                        //menampilkan kuncijawaban (string ke char) |char|string[index]|index|
                        kunciJawaban = soalBag[randomIndexSoal, 5][0];
                        //menambah urutan Soal
                        urutanSoal++;

                        soalSelesai[randomIndexSoal] = true;

                        ambilSoal = false;
                        break;
                    } else
                    {
                        continue;
                    }
                }
            }
        }
    }

    public void Opsi(string opsiHuruf)
    {
        CheckJawaban(opsiHuruf[0]);
        //kondisi untuk melanjutkan soal atau menampilkan skor nilai
        if (indexSoal == maxSoal - 1)
        {
            isHasil = true;
        } else
        {
            indexSoal++; //lanjut ke soal berikut
            ambilSoal = true;
        }
        Feedback.SetActive(true);
    }

    private float HitungNilai()
    {
        return nilai = (float)jwbBenar / maxSoal * 100;
    }

    public void CheckJawaban(char huruf)
    {
        //Mengaktifkan object benar atau salah dengan kondisi jawaban yang seusai dengan kunci jawaban pada array index kunciJawaban
        if (huruf.Equals(kunciJawaban))
        {
            benar.SetActive(true);
            jwbBenar++;
        } else
        {
            salah.SetActive(true);
            jwbSalah++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Feedback.activeSelf)
        {
            durasiPenilaian -= Time.deltaTime;
            //kondisi pertanyaan habis akan masuk ke panel popup tampilan Nilai
            if (isHasil)
            {
                imgPenilaian.SetActive(true);
                imgHasil.SetActive(false);

                if(durasiPenilaian <= 0)
                {
                    jawabBnr.text = "" + jwbBenar;
                    jawabSlh.text = "" + jwbSalah;
                    hasilNilai.text = "" + HitungNilai();
                    if (HitungNilai() >= 90)
                    {
                        hasilNilaiHuruf.text = "A";
                    } else if (nilai >= 75)
                    {
                        hasilNilaiHuruf.text = "B";
                    } else if (nilai >= 60)
                    {
                        hasilNilaiHuruf.text = "C";
                    } else
                    {
                        hasilNilaiHuruf.text = "D";
                    }

                    imgPenilaian.SetActive(false);
                    imgHasil.SetActive(true);

                    durasiPenilaian = 0;
                }
            } else //kondisi pertanyaan belum habis akan menampilkan popup gambar Benar dan salah yang diberidurasi 0.3 - 0.5 setiap popupnya, lalu lanjut ke Tampilkan Soal
            {
                imgPenilaian.SetActive(true);
                imgHasil.SetActive(false);

                if (durasiPenilaian <= 0)
                {
                    Feedback.SetActive(false);
                    benar.SetActive(false);
                    salah.SetActive(false);
                    durasiPenilaian = durasi;

                    TampilkanSoal();
                }
            }
        }
    }

    public void LhtNilai()
    {
        StartCoroutine(DelaybtnMenu());
    }
    IEnumerator DelaybtnMenu()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");
    }

    public void btnBack()
    {
        StartCoroutine(DelaybtnBack());
    }
    IEnumerator DelaybtnBack()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");
    }

}

