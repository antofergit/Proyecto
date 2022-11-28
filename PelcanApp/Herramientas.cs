using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace PelcanApp
{
    public static class Herramientas
    {

        public static Dictionary<string,byte[]> DiccionarioImagenes()
        {
            Dictionary<string, byte[]> diccionario = new Dictionary<string, byte[]>();

            diccionario.Add("Affenpinscher", Properties.Resources.affenpinscher);
            diccionario.Add("akita japones", Properties.Resources.akita_japones);
            diccionario.Add("american_staffordshire_terrier", Properties.Resources.american_staffordshire_terrier);
            diccionario.Add("basenji", Properties.Resources.basenji);
            diccionario.Add("basset_azul_de_gascuña", Properties.Resources.basset_azul_de_gascuña);
            diccionario.Add("basset_hound", Properties.Resources.basset_hound);
            diccionario.Add("basset_leonado_de_bretaña", Properties.Resources.basset_leonado_de_bretaña);
            diccionario.Add("beagle", Properties.Resources.beagle);
            diccionario.Add("beauceron", Properties.Resources.beauceron);
            diccionario.Add("bedlington_terrier", Properties.Resources.bedlington_terrier);
            diccionario.Add("bergamasco", Properties.Resources.bergamasco);
            diccionario.Add("bichon_boloñes", Properties.Resources.bichon_boloñes);
            diccionario.Add("bichon_frise", Properties.Resources.bichon_frise);
            diccionario.Add("bobtail_o_antiguo_pastor_ingles", Properties.Resources.bobtail_o_antiguo_pastor_ingles);
            diccionario.Add("Affenpinscher", Properties.Resources.bodeguero_andaluz);
            diccionario.Add("Affenpinscher", Properties.Resources.border_collie);
            diccionario.Add("Affenpinscher", Properties.Resources.border_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.borzoi);
            diccionario.Add("Affenpinscher", Properties.Resources.boston_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.boxer);
            diccionario.Add("Affenpinscher", Properties.Resources.boyero_de_berna);
            diccionario.Add("Affenpinscher", Properties.Resources.boyero_de_flandes);
            diccionario.Add("Affenpinscher", Properties.Resources.bracco_italiano);
            diccionario.Add("Affenpinscher", Properties.Resources.braco_aleman_de_pelo_corto);
            diccionario.Add("Affenpinscher", Properties.Resources.braco_aleman_de_pelo_duro);
            diccionario.Add("Affenpinscher", Properties.Resources.braco_de_weimar);
            diccionario.Add("Affenpinscher", Properties.Resources.braco_hungaro);
            diccionario.Add("Affenpinscher", Properties.Resources.braco_hungaro_de_pelo_duro);
            diccionario.Add("Affenpinscher", Properties.Resources.breton);
            diccionario.Add("Affenpinscher", Properties.Resources.buhund_noruego);
            diccionario.Add("Affenpinscher", Properties.Resources.bulldog);
            diccionario.Add("Affenpinscher", Properties.Resources.bulldog_frances);
            diccionario.Add("Affenpinscher", Properties.Resources.bullmastiff);
            diccionario.Add("Affenpinscher", Properties.Resources.bull_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.bull_terrier_miniatura);
            diccionario.Add("Affenpinscher", Properties.Resources.cairn_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.caniche_eneno);
            diccionario.Add("Affenpinscher", Properties.Resources.caniche_grande);
            diccionario.Add("Affenpinscher", Properties.Resources.caniche_toy);
            diccionario.Add("Affenpinscher", Properties.Resources.carlino);
            diccionario.Add("Affenpinscher", Properties.Resources.cavalier_king_charles_spaniel);
            diccionario.Add("Affenpinscher", Properties.Resources.cazador_de_alces_noruego);
            diccionario.Add("Affenpinscher", Properties.Resources.chihuahua);
            diccionario.Add("Affenpinscher", Properties.Resources.chihuahua_de_pelo_largo);
            diccionario.Add("Affenpinscher", Properties.Resources.chin_japones);
            diccionario.Add("Affenpinscher", Properties.Resources.chow_chow_de_pelo_duro);
            diccionario.Add("Affenpinscher", Properties.Resources.chow_chow_de_pelo_suave);
            diccionario.Add("Affenpinscher", Properties.Resources.clumber_spaniel);
            diccionario.Add("Affenpinscher", Properties.Resources.cobrador_de_nueva_escocia);
            diccionario.Add("Affenpinscher", Properties.Resources.cocker_espaniel_americano);
            diccionario.Add("Affenpinscher", Properties.Resources.cocker_espaniel_ingles);
            diccionario.Add("Affenpinscher", Properties.Resources.collie_barbudo);
            diccionario.Add("Affenpinscher", Properties.Resources.collie_de_pelo_corto);
            diccionario.Add("Affenpinscher", Properties.Resources.corgi_gales);
            diccionario.Add("Affenpinscher", Properties.Resources.corgi_gales_de_pembroke);
            diccionario.Add("Affenpinscher", Properties.Resources.coton_de_tulear);
            diccionario.Add("Affenpinscher", Properties.Resources.crestado_chino);
            diccionario.Add("Affenpinscher", Properties.Resources.dachshund);
            diccionario.Add("Affenpinscher", Properties.Resources.dalmata);
            diccionario.Add("Affenpinscher", Properties.Resources.dandie_dinmont_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.dobermann);
            diccionario.Add("Affenpinscher", Properties.Resources.dogo_de_burdeos);
            diccionario.Add("Affenpinscher", Properties.Resources.esquimal_canadiense);
            diccionario.Add("Affenpinscher", Properties.Resources.field_spaniel);
            diccionario.Add("Affenpinscher", Properties.Resources.finlandes_de_laponia);
            diccionario.Add("Affenpinscher", Properties.Resources.foxhound);
            diccionario.Add("Affenpinscher", Properties.Resources.fox_terrier_de_pelo_duro);
            diccionario.Add("Affenpinscher", Properties.Resources.fox_terrier_de_pelo_liso);
            diccionario.Add("Affenpinscher", Properties.Resources.galgo);
            diccionario.Add("Affenpinscher", Properties.Resources.galgo_arabe);
            diccionario.Add("Affenpinscher", Properties.Resources.galgo_italiano);
            diccionario.Add("Affenpinscher", Properties.Resources.galgo_persa);
            diccionario.Add("Affenpinscher", Properties.Resources.golden_retriever);
            diccionario.Add("Affenpinscher", Properties.Resources.gran_azul_de_gascuña);
            diccionario.Add("Affenpinscher", Properties.Resources.gran_danes);
            diccionario.Add("Affenpinscher", Properties.Resources.grifon_belga);
            diccionario.Add("Affenpinscher", Properties.Resources.grifon_de_bruselas);
            diccionario.Add("Affenpinscher", Properties.Resources.grifon_vandeano_basset);
            diccionario.Add("Affenpinscher", Properties.Resources.grifon_vandeano_basset_pequeño);
            diccionario.Add("Affenpinscher", Properties.Resources.habanero);
            diccionario.Add("Affenpinscher", Properties.Resources.hamilton_stovare);
            diccionario.Add("Affenpinscher", Properties.Resources.havawart);
            diccionario.Add("Affenpinscher", Properties.Resources.husky_siberiano);
            diccionario.Add("Affenpinscher", Properties.Resources.keeshond);
            diccionario.Add("Affenpinscher", Properties.Resources.kerry_blue_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.king_charles_spaniel);
            diccionario.Add("Affenpinscher", Properties.Resources.komondor);
            diccionario.Add("Affenpinscher", Properties.Resources.kuvasz_hungaro);
            diccionario.Add("Affenpinscher", Properties.Resources.labarador_retriever);
            diccionario.Add("Affenpinscher", Properties.Resources.laekenois);
            diccionario.Add("Affenpinscher", Properties.Resources.lakeland_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.lancashire_heeler);
            diccionario.Add("Affenpinscher", Properties.Resources.lebrel_escoces);
            diccionario.Add("Affenpinscher", Properties.Resources.leonberger);
            diccionario.Add("Affenpinscher", Properties.Resources.lhasa_apso);
            diccionario.Add("Affenpinscher", Properties.Resources.lobero_irlandes);
            diccionario.Add("Affenpinscher", Properties.Resources.lowchen);
            diccionario.Add("Affenpinscher", Properties.Resources.malamute_de_alaska);
            diccionario.Add("Affenpinscher", Properties.Resources.malinois);
            diccionario.Add("Affenpinscher", Properties.Resources.maltes);
            diccionario.Add("Affenpinscher", Properties.Resources.manchester_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.mastin_ingles);
            diccionario.Add("Affenpinscher", Properties.Resources.mastin_napolitano);
            diccionario.Add("Affenpinscher", Properties.Resources.mastin_tibetano);
            diccionario.Add("Affenpinscher", Properties.Resources.mestizo);
            diccionario.Add("Affenpinscher", Properties.Resources.munsterlander);
            diccionario.Add("Affenpinscher", Properties.Resources.norfolk_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.otterhound);
            diccionario.Add("Affenpinscher", Properties.Resources.papillon);
            diccionario.Add("Affenpinscher", Properties.Resources.parson_jack_russell_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_aleman);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_australiano);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_belga);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_belga_laekenois);
            diccionario.Add("Affenpinscher", Properties.Resources.laekenois);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_belga_malinois);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_belga_tervueren);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_de_anatolia);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_de_brie);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_de_los_pirineos);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_de_maremma);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_de_shetland);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_ganadero);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_lapon_de_suecia);
            diccionario.Add("Affenpinscher", Properties.Resources.pastor_polaco_de_las_llanuras);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_del_faraon);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_de_agua_español);
            diccionario.Add("Affenpinscher", Properties.Resources.Perro_de_agua_irlandes);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_de_agua_potugues);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_de_canaan);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_de_montaña_de_los_pirineos);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_salchicha_de_pelo_duro);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_salchicha_de_pelo_liso);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_salchicha_miniatura_de_pelo_duro);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_salchicha_miniatura_de_pelo_largo);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_salchicha_miniatura_de_pelo_liso);
            diccionario.Add("Affenpinscher", Properties.Resources.perro_serra_da_estrela);
            diccionario.Add("Affenpinscher", Properties.Resources.pinscher_aleman);
            diccionario.Add("Affenpinscher", Properties.Resources.pinscher_miniatura);
            diccionario.Add("Affenpinscher", Properties.Resources.pitbull_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.podenco_ibicenco);
            diccionario.Add("Affenpinscher", Properties.Resources.pointer);
            diccionario.Add("Affenpinscher", Properties.Resources.pomerania);
            diccionario.Add("Affenpinscher", Properties.Resources.puli_hungaro);
            diccionario.Add("Affenpinscher", Properties.Resources.retriever_de_chesapeake);
            diccionario.Add("Affenpinscher", Properties.Resources.retriever_de_pelo_liso);
            diccionario.Add("Affenpinscher", Properties.Resources.retriever_de_pelo_rizado);
            diccionario.Add("Affenpinscher", Properties.Resources.rhodesian_ridgeback);
            diccionario.Add("Affenpinscher", Properties.Resources.rottweiler);
            diccionario.Add("Affenpinscher", Properties.Resources.rough_collie);
            diccionario.Add("Affenpinscher", Properties.Resources.sabueso_bavaro_de_montaña);
            diccionario.Add("Affenpinscher", Properties.Resources.sabueso_italiano);
            diccionario.Add("Affenpinscher", Properties.Resources.samoyedo);
            diccionario.Add("Affenpinscher", Properties.Resources.san_bernardo);
            diccionario.Add("Affenpinscher", Properties.Resources.schipperke);
            diccionario.Add("Affenpinscher", Properties.Resources.schnauzer_estandar);
            diccionario.Add("Affenpinscher", Properties.Resources.schnauzer_gigante);
            diccionario.Add("Affenpinscher", Properties.Resources.schnauzer_miniatura);
            diccionario.Add("Affenpinscher", Properties.Resources.sealyham_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.setter_escoces);
            diccionario.Add("Affenpinscher", Properties.Resources.setter_ingles);
            diccionario.Add("Affenpinscher", Properties.Resources.setter_irlandes);
            diccionario.Add("Affenpinscher", Properties.Resources.setter_irlandes_rojo_y_blanco);
            diccionario.Add("Affenpinscher", Properties.Resources.shar_pei);
            diccionario.Add("Affenpinscher", Properties.Resources.shiba_inu_japones);
            diccionario.Add("Affenpinscher", Properties.Resources.shih_tzu);
            diccionario.Add("Affenpinscher", Properties.Resources.skye_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.soft_coated_wheaten_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.spaniel_holandes);
            diccionario.Add("Affenpinscher", Properties.Resources.spaniel_tibetano);
            diccionario.Add("Affenpinscher", Properties.Resources.spinone_italiano);
            diccionario.Add("Affenpinscher", Properties.Resources.spitz_aleman_medio);
            diccionario.Add("Affenpinscher", Properties.Resources.spitz_aleman_pequeño);
            diccionario.Add("Affenpinscher", Properties.Resources.spitz_finlandes);
            diccionario.Add("Affenpinscher", Properties.Resources.spitz_japones);
            diccionario.Add("Affenpinscher", Properties.Resources.springer_spaniel_gales);
            diccionario.Add("Affenpinscher", Properties.Resources.springer_spaniel_ingles);
            diccionario.Add("Affenpinscher", Properties.Resources.staffordshire_bull_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.sussex_spaniel);
            diccionario.Add("Affenpinscher", Properties.Resources.terranova);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_australiano);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_checo);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_de_airedale);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_escoces);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_gales);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_irlandes);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_norwich);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_sedoso_australiano);
            diccionario.Add("Affenpinscher", Properties.Resources.terrier_tibetano);
            diccionario.Add("Affenpinscher", Properties.Resources.toy_terrier_ingles);
            diccionario.Add("Affenpinscher", Properties.Resources.vallhund_sueco);
            diccionario.Add("Affenpinscher", Properties.Resources.west_highland_white_terrier);
            diccionario.Add("Affenpinscher", Properties.Resources.whippet);
            diccionario.Add("Affenpinscher", Properties.Resources.xoloitzcuintle);
            diccionario.Add("Affenpinscher", Properties.Resources.yorkshire_terrier);

            return diccionario;

        }


        public static BitmapImage DameImagen(byte[] recurso)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(recurso);
            bitmapImage.EndInit();
            return bitmapImage;

        }

        public static BitmapImage DameImagen(string path)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(path, UriKind.Relative);
            bitmapImage.EndInit();
            return bitmapImage;
        }

    }
}
