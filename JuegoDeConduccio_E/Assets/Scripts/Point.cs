using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Point : MonoBehaviour
{
    public float point = 0;
    public GameObject meta;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public static float tiempo;
    [SerializeField] float tiemponivel = 120;
    public static int vueltas;
    [SerializeField] TMP_Text txtTiempo, txtVueltas;
    [SerializeField] GameObject txtGanar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.tiempo = tiemponivel;
        txtTiempo.text = GameManager.tiempo.ToString("00");

        GameManager.vueltas = 0;
        txtVueltas.text = "Vuelta " + GameManager.vueltas + "/3";
    }

    void IrACreditos(){
        SceneManager.LoadScene("Creditos");
    }

    // Update is called once per frame
    void Update()
    {
        if (point >= 3){
            txtGanar.SetActive(true);
            Invoke("IrACreditos", 3);
        }
        GameManager.tiempo -= Time.deltaTime;
        if (GameManager.tiempo < 0){
            GameManager.tiempo = 0;
        }
        string minutos, segundos;
        minutos = Mathf.Floor(GameManager.tiempo / 60).ToString("00");
        segundos = Mathf.Floor(GameManager.tiempo % 60).ToString("00");
        txtTiempo.text = minutos + ":" + segundos;
        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Inicio");
        }
    }
    

    private void OnTriggerEnter(Collider col){
        if (col.gameObject == point1){
            col.gameObject.SetActive(false);
            point2.SetActive(true);
        }
        if (col.gameObject == point2){
            col.gameObject.SetActive(false);
            point3.SetActive(true);
        }
        if (col.gameObject == point3){
            col.gameObject.SetActive(false);
            meta.SetActive(true);
        }
        if (col.gameObject == meta){
            col.gameObject.SetActive(false);
            point1.SetActive(true);
            point++;
            GameManager.vueltas++;
            txtVueltas.text = "Vuelta " + GameManager.vueltas + "/3";
        }
        
    }
}
